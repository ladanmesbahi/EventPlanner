using EventPlanner.Domain.Enums;
using EventPlanner.Domain.Infrastructure;

namespace EventPlanner.Domain.Entities
{
    public sealed class Invitation : BaseEntity
    {
        internal Invitation(Guid id, Member member, Conference conference)
            : base(id)
        {
            MemberId = member.Id;
            ConferenceId = conference.Id;
            Status = InvitationStatus.Pending;
            CreatedOnUtc = DateTime.UtcNow;
        }

        private Invitation()
        {
        }

        public Guid ConferenceId { get; private set; }

        public Guid MemberId { get; private set; }

        public InvitationStatus Status { get; private set; }

        public DateTime CreatedOnUtc { get; private set; }

        public DateTime? ModifiedOnUtc { get; private set; }
    }
}
