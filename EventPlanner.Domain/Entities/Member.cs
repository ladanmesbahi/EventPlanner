using EventPlanner.Domain.Infrastructure;
using EventPlanner.Domain.ValueObjects;

namespace EventPlanner.Domain.Entities
{
    public class Member : AggregateRoot, IAuditableEntity
    {
        public Member(Guid id, FirstName firstName, LastName lastName, Email email) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public Email Email { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
