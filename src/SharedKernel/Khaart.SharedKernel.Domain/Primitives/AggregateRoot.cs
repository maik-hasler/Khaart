using Khaart.SharedKernel.Domain.Messaging;

namespace Khaart.SharedKernel.Domain.Primitives;

public abstract class AggregateRoot<TId>(
    TId id)
    : Entity<TId>(id),
    IAggregateRoot
    where TId : struct
{
    private readonly List<DomainEvent> _domainEvents = [];

    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents;

    public void ClearDomainEvents() => _domainEvents.Clear();

    protected void RaiseDomainEvent(DomainEvent domainEvent) => _domainEvents.Add(domainEvent);
}
