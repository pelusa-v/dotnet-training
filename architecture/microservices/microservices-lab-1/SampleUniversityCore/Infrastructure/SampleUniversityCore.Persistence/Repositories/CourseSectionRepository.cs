using Microsoft.EntityFrameworkCore;
using SampleUniversityCore.Application;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Persistence.Repositories;

public class CourseSectionRepository : BaseRepository<CourseSection>, ICourseSectionRepository
{
    private readonly SampleUniversityDbContext _dbContext;

    public CourseSectionRepository(SampleUniversityDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<CourseSection>> SearchCourseSectionDetailAsync(int courseId, int sectionId)
    {
        return await _dbContext.CourseSections
            .Where(x => x.CourseId == courseId && x.SectionId == sectionId)
            .Include(x => x.Course)
            .Include(x => x.Section)
            .Include(x => x.CourseClasses)
                .ThenInclude(c => c.Teacher)
            .Include(x => x.CourseClasses)
                .ThenInclude(c => c.ClassType)
            .ToListAsync();
    }
}
