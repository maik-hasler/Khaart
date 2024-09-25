using Khaart.SharedKernel.Domain.Monads;
using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public interface ICommandHandler<TCommand, TResponse>
    : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>;
