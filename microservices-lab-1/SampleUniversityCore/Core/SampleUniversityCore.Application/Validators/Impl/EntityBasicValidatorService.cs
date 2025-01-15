using System.Linq.Expressions;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Application.Services.DTOs;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application.Validators;

public class EntityBasicValidatorService : IEntityBasicValidatorService
{
    private readonly ICourseRepository _courseRepository;
    private readonly ISectionRepository _sectionRepository;
    private readonly ICourseClassRepository _courseClassRepository;
    private readonly ICourseSectionRepository _courseSectionRepository;

    public EntityBasicValidatorService(ICourseRepository courseRepository, ISectionRepository sectionRepository, ICourseClassRepository courseClassRepository,
        ICourseSectionRepository courseSectionRepository)
    {
        _courseRepository = courseRepository;
        _sectionRepository = sectionRepository;
        _courseClassRepository = courseClassRepository;
        _courseSectionRepository = courseSectionRepository;
    }

    public async Task<ResultDTO<T>> ValidateCourseAsync<T>(ResultDTO<T> result, Expression<Func<CourseSection, bool>> predicate)
    {
        var exists = await _courseSectionRepository.Exist(predicate);
        if (!exists)
        {
            result.Failure("CourseSection not found");
        }
        return result;
    }
}
