using Domain.Infrastructure;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Member : BaseEntity
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
    }
}
