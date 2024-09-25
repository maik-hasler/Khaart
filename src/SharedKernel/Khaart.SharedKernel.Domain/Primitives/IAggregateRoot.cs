using Khaart.SharedKernel.Domain.Messaging;

namespace Khaart.SharedKernel.Domain.Primitives;

public interface IAggregateRoot
{
    IReadOnlyCollection<DomainEvent> DomainEvents { get; }

    void ClearDomainEvents();
}
