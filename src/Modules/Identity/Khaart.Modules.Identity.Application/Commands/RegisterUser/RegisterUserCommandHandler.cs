using Khaart.Modules.Identity.Application.Abstractions;
using Khaart.Modules.Identity.Domain.Users;
using Khaart.SharedKernel.Application.Messaging;
using Khaart.SharedKernel.Domain.Monads;

namespace Khaart.Modules.Identity.Application.Commands.RegisterUser;

internal sealed class RegisterUserCommandHandler(
    IIdentityDbContext dbContext)
    : ICommandHandler<RegisterUserCommand, User>
{
    public async Task<Result<User>> Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken)
    {
        var user = User.Create();

        await dbContext.Users.AddAsync(user, cancellationToken);
    }
}
