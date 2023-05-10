using EventPlanner.Application.Abstractions.Messaging;
using EventPlanner.Application.Dtos;
using EventPlanner.Domain.Errors;
using EventPlanner.Domain.Repositories;
using EventPlanner.Domain.Shared;

namespace EventPlanner.Application.Queries.Conference
{
    internal sealed class GetConferenceByIdQueryHandler : IQueryHandler<GetConferenceByIdQuery, ConferenceResponse>
    {
        private readonly IConferenceRepository _conferenceRepository;

        public GetConferenceByIdQueryHandler(IConferenceRepository conferenceRepository)
        {
            _conferenceRepository = conferenceRepository;
        }

        public async Task<Result<ConferenceResponse>> Handle(GetConferenceByIdQuery request, CancellationToken cancellationToken)
        {
            var conference = await _conferenceRepository.GetById(
                 request.ConferenceId,
                 cancellationToken);

            if (conference is null)
            {
                return Result.Failure<ConferenceResponse>(
                    DomainErrors.Conference.NotFound(request.ConferenceId));
            }

            var response = new ConferenceResponse(
                conference.Id,
                conference.Name,
                conference.Location,
                $"{conference.Creator.FirstName.Value}" +
                $" {conference.Creator.LastName.Value}",
                conference
                    .Attendees
                    .Select(attendee => new AttendeeResponse(
                        attendee.MemberId,
                        attendee.CreatedOnUtc))
                    .ToList(),
                conference
                    .Invitations
                    .Select(invitation => new InvitationResponse(
                        invitation.Id,
                        invitation.Status))
                    .ToList());

            return response;
        }
    }
}
