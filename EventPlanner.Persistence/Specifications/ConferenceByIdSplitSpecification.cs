using EventPlanner.Domain.Entities;

namespace EventPlanner.Persistence.Specifications
{
    internal class ConferenceByIdSplitSpecification : Specification<Conference>
    {
        public ConferenceByIdSplitSpecification(Guid conferenceId) : base(conference => conference.Id == conferenceId)
        {
            AddInclude(conference => conference.Creator);
            AddInclude(conference => conference.Attendees);
            AddInclude(conference => conference.Invitations);

            IsSplitQuery = true;
        }
    }

}
