namespace EventPlanner.Domain.Entities
{
    public class Attendee
    {
        internal Attendee(Invitation invitation) : this()
        {
            ConferenceId = invitation.ConferenceId;
            MemberId = invitation.MemberId;
            CreatedOnUtc = DateTime.UtcNow;
        }

        private Attendee()
        {
        }
        public Guid ConferenceId { get; private set; }
        public Guid MemberId { get; private set; }
        public DateTime CreatedOnUtc { get; private set; }
    }
}
