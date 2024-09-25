using Khaart.Modules.Identity.Domain.Users.DomainEvents;
using Khaart.SharedKernel.Domain.Primitives;

namespace Khaart.Modules.Identity.Domain.Users;

public sealed class User
    : AggregateRoot<UserId>
{
    private User(
        UserId id)
        : base(id)
    {
    }

    public static User Create()
    {
        var user = new User(
            new UserId(Guid.NewGuid()));

        user.RaiseDomainEvent(
            new UserCreatedDomainEvent(
                Guid.NewGuid(),
                DateTimeOffset.UtcNow,
                user.Id));

        return user;
    }
}
