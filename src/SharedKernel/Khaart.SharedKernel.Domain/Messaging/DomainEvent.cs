using MediatR;

namespace Khaart.SharedKernel.Domain.Messaging;

public abstract record DomainEvent(
    Guid Id,
    DateTimeOffset OccurredOnUtc)
    : INotification;
