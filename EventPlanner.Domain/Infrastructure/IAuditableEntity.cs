namespace EventPlanner.Domain.Infrastructure
{
    public interface IAuditableEntity
    {
        DateTime CreatedOnUtc { get; set; }
        DateTime? ModifiedOnUtc { get; set; }
    }
}
