using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Persistence.Repositories;


public class CourseClassRepository : BaseRepository<CourseClass>, ICourseClassRepository
{
    public CourseClassRepository(SampleUniversityDbContext dbContext) : base(dbContext)
    {
    }
}
