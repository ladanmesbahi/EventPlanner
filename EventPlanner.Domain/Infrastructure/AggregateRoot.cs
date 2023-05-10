namespace EventPlanner.Domain.Infrastructure
{
    public abstract class AggregateRoot : BaseEntity
    {
        protected AggregateRoot(Guid id) : base(id)
        {
        }
        protected AggregateRoot()
        {

        }
    }
}
