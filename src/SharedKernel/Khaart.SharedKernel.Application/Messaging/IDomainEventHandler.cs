using Khaart.SharedKernel.Domain.Messaging;
using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public interface IDomainEventHandler<in TDomainEvent>
    : INotificationHandler<TDomainEvent>
    where TDomainEvent : DomainEvent;
