using EventPlanner.Domain.Enums;
using EventPlanner.Domain.Infrastructure;

namespace EventPlanner.Domain.Entities
{
    public class Conference : AggregateRoot
    {
        private readonly List<Invitation> _invitations = new();
        private readonly List<Attendee> _attendees = new();
        private Conference(
            Guid id,
            Member creator,
            ConferenceType type,
            DateTime scheduleAtUtc,
            string name,
            string? location)
            : base(id)
        {
            Creator = creator;
            Type = type;
            ScheduleAtUtc = scheduleAtUtc;
            Name = name;
            Location = location;
        }

        private Conference()
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

        public static Conference Create(
           Guid id,
           Member creator,
           ConferenceType type,
           DateTime scheduledAtUtc,
           string name,
           string? location,
           int? maximumNumberOfAttendees,
           int? invitationsValidBeforeInHours)
        {
            var conference = new Conference(
                id,
                creator,
                type,
                scheduledAtUtc,
                name,
                location);

            //conference.CalculateConferenceTypeDetails(maximumNumberOfAttendees, invitationsValidBeforeInHours);

            return conference;
        }
    }
}
