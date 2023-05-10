using EventPlanner.Domain.Entities;

namespace EventPlanner.Domain.Repositories
{
    public interface IConferenceRepository
    {
        Task<Conference?> GetById(Guid id, CancellationToken cancellationToken = default);
    }
}
