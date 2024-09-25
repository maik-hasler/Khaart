using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public abstract record IntegrationEvent(
    Guid Id,
    DateTimeOffset OccurredOnUtc)
    : INotification;
