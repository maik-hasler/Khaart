using Khaart.SharedKernel.Domain.Monads;
using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public interface IQuery<TResponse>
    : IRequest<Result<TResponse>>;
