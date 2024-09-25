using Khaart.Modules.Identity.Domain.Users;
using Khaart.SharedKernel.Application.Messaging;

namespace Khaart.Modules.Identity.Application.Commands.RegisterUser;

public sealed record RegisterUserCommand
    : ICommand<User>;
