using Khaart.SharedKernel.Domain.Primitives;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Khaart.SharedKernel.Infrastructure.Persistence.Interceptors;

public sealed class PublishDomainEventsInterceptor(
    IPublisher publisher)
    : SaveChangesInterceptor
{
    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        if (eventData.Context is not null)
        {
            await PublishDomainEventsAsync(eventData.Context, cancellationToken);
        }

        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private async Task PublishDomainEventsAsync(
        DbContext dbContext,
        CancellationToken cancellationToken = default)
    {
        var domainEvents = dbContext
            .ChangeTracker
            .Entries<IAggregateRoot>()
            .Select(entry => entry.Entity)
            .SelectMany(aggreagteRoot =>
            {
                var domainEvents = aggreagteRoot.DomainEvents;

                aggreagteRoot.ClearDomainEvents();

                return domainEvents;
            })
            .ToList();

        await Task.WhenAll(domainEvents
            .Select(domainEvent => publisher
                .Publish(domainEvent, cancellationToken)));
    }
}
