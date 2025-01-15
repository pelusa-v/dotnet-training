using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Persistence.Repositories;

public class SectionRepository : BaseRepository<Section>, ISectionRepository
{
    public SectionRepository(SampleUniversityDbContext dbContext) : base(dbContext)
    {   
    }
}
