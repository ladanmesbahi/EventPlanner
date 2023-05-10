using EventPlanner.Domain.Entities;
using EventPlanner.Domain.Repositories;
using EventPlanner.Persistence.Specifications;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Persistence.Repositories
{
    public class ConferenceRepository : IConferenceRepository
    {
        private readonly DbSet<Conference> _conferences;
        public ConferenceRepository(ApplicationDbContext dbContext)
        {
            _conferences = dbContext.Set<Conference>();
        }
        public async Task<Conference?> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(new ConferenceByIdSplitSpecification(id))
            .FirstOrDefaultAsync(cancellationToken);
        }

        private IQueryable<Conference> ApplySpecification(Specification<Conference> specification)
        {
            return SpecificationEvaluator.GetQuery(
                _conferences,
                specification);
        }
    }
}
