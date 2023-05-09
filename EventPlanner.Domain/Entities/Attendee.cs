namespace EventPlanner.Domain.Entities
{
    public class Attendee
    {
        public Attendee(Invitation invitation)
        {
            ConferenceId = invitation.ConferenceId;
            MemberId = invitation.MemberId;
            CreatedOnUtc = DateTime.UtcNow;
        }
        public Guid ConferenceId { get; private set; }
        public Guid MemberId { get; private set; }
        public DateTime CreatedOnUtc { get; private set; }
    }
}
