using EventPlanner.Domain.Shared;
using MediatR;

namespace EventPlanner.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
