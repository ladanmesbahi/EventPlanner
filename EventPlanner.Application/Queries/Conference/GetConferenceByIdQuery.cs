using EventPlanner.Application.Abstractions.Messaging;
using EventPlanner.Application.Dtos;

namespace EventPlanner.Application.Queries.Conference
{
    public sealed record GetConferenceByIdQuery(Guid ConferenceId) : IQuery<ConferenceResponse>;
}
