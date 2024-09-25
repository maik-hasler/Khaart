using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public interface IIntegrationEventHandler<in TIntegrationEvent>
    : INotificationHandler<TIntegrationEvent>
    where TIntegrationEvent : IntegrationEvent;
