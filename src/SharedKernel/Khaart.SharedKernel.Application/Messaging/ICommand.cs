using Khaart.SharedKernel.Domain.Monads;
using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public interface ICommand<TResponse>
    : IRequest<Result<TResponse>>;
