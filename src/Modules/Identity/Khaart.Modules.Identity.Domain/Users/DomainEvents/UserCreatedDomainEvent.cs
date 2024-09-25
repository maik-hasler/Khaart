using Khaart.SharedKernel.Domain.Messaging;

namespace Khaart.Modules.Identity.Domain.Users.DomainEvents;

public sealed record UserCreatedDomainEvent(
    Guid Id,
    DateTimeOffset OccurredOnUtc,
    UserId UserId)
    : DomainEvent(Id, OccurredOnUtc);
