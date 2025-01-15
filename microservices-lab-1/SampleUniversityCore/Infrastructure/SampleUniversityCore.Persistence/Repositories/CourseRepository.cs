using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Persistence.Repositories;

public class CourseRepository : BaseRepository<Course>, ICourseRepository
{
    public CourseRepository(SampleUniversityDbContext dbContext) : base(dbContext)
    {
    }
}
