using MediatR;
using SampleUniversityCore.Application.Services.DTOs;

namespace SampleUniversityCore.Application.FeaturesCourses.SearchClasses;

public class SearchClassesHandler(ICourseSectionService courseSectionService) : IRequestHandler<SearchClassesQuery, ResultDTO<List<CourseSectionDetailDTO>>>
{
    public async Task<ResultDTO<List<CourseSectionDetailDTO>>> Handle(SearchClassesQuery request, CancellationToken cancellationToken)
    {
        return await courseSectionService.SearchCourseSectionClassesAsync(request.Search); 
    }
}
