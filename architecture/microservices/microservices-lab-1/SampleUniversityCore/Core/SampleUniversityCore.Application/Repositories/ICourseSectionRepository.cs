using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application.Repositories;

public interface ICourseSectionRepository : IBaseRepository<CourseSection>
{
    Task<List<CourseSection>> SearchCourseSectionDetailAsync(int courseId, int sectionId);
}
