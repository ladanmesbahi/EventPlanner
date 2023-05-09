using EventPlanner.Domain.Enums;
using EventPlanner.Domain.Infrastructure;

namespace EventPlanner.Domain.Entities
{
    public class Invitation : BaseEntity
    {
        public Invitation(Guid id, Member member, Conference conference) : base(id)
        {
            MemberId = member.Id;
            ConferenceId = conference.Id;
            CreatedOnUtc = DateTime.UtcNow;
        }

        public Guid ConferenceId { get; set; }
        public Guid MemberId { get; set; }
        public InvitationStatus Status { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }

    }
}
