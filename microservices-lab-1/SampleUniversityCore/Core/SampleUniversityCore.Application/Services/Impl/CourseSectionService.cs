using AutoMapper;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Application.Services.DTOs;
using SampleUniversityCore.Application.Validators;

namespace SampleUniversityCore.Application.Services;

public class CourseSectionService : ICourseSectionService
{
    private readonly ICourseClassRepository _courseClassRepository;
    private readonly ICourseRepository _courseRepository;
    private readonly ISectionRepository _sectionRepository;
    private readonly IEntityBasicValidatorService _entityBasicValidatorService;
    private readonly ICourseSectionRepository _courseSectionRepository;
    private readonly IMapper _mapper;

    public CourseSectionService(ICourseClassRepository courseClassRepository, ICourseRepository courseRepository, ISectionRepository sectionRepository,
        IEntityBasicValidatorService entityBasicValidatorService, ICourseSectionRepository courseSectionRepository, IMapper mapper)
    {
        _courseClassRepository = courseClassRepository;
        _courseRepository = courseRepository;
        _sectionRepository = sectionRepository;
        _entityBasicValidatorService = entityBasicValidatorService;
        _courseSectionRepository = courseSectionRepository;
        _mapper = mapper;
    }
    
    public Task CraeateCourseSectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetCourseSectionDetailAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResultDTO<List<CourseSectionDetailDTO>>> SearchCourseSectionClassesAsync(List<SearchCourseSectionClassesDTO> search)
    {
        var details = new List<CourseSectionDetailDTO>();
        var result = new ResultDTO<List<CourseSectionDetailDTO>>(details);

        foreach (var searchCourse in search)
        {
            await _entityBasicValidatorService.ValidateCourseAsync(result, x => x.CourseId == searchCourse.CourseId && x.SectionId == searchCourse.SectionId);
            if (!result.IsSuccess)
                return result;
            
            var courseSections = await _courseSectionRepository.SearchCourseSectionDetailAsync(searchCourse.CourseId, searchCourse.SectionId);
            var mapped = _mapper.Map<List<CourseSectionDetailDTO>>(courseSections);
            result.Value.AddRange(mapped);
        }

        return result;
    }
}
