using Domain.Enums;
using Domain.Infrastructure;

namespace Domain.Entities
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
    }
}
