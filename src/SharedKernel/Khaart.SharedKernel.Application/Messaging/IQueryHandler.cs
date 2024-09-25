using Khaart.SharedKernel.Domain.Monads;
using MediatR;

namespace Khaart.SharedKernel.Application.Messaging;

public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>;
