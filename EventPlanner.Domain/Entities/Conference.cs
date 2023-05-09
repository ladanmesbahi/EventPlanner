using EventPlanner.Domain.Enums;
using EventPlanner.Domain.Errors;
using EventPlanner.Domain.Infrastructure;
using EventPlanner.Domain.Shared;

namespace EventPlanner.Domain.Entities
{
    public class Conference : AggregateRoot
    {
        private readonly List<Invitation> _invitations = new();
        private readonly List<Attendee> _attendees = new();
        public Conference(Guid id) : base(id)
        {
        }

        public Member Creator { get; set; }
        public ConferenceType Type { get; set; }
        public string Name { get; set; }
        public DateTime ScheduleAtUtc { get; set; }
        public string? Location { get; set; }
        public int? MaximumNumberOfAttendees { get; set; }
        public DateTime? InvitationExpirationUtc { get; set; }
        public int NumberOfAttendees { get; set; }
        public IReadOnlyCollection<Attendee> Attendees => _attendees;
        public IReadOnlyCollection<Invitation> Invitations => _invitations;

        public Result<Invitation> SendInvitation(Member member)
        {
            if (Creator.Id == member.Id)
            {
                return Result.Failure<Invitation>(DomainErrors.Conference.InvitingCreator);
            }

            if (ScheduleAtUtc < DateTime.UtcNow)
            {
                return Result.Failure<Invitation>(DomainErrors.Conference.AlreadyPassed);
            }

            var invitation = new Invitation(Guid.NewGuid(), member, this);

            _invitations.Add(invitation);

            return invitation;
        }
    }
}
