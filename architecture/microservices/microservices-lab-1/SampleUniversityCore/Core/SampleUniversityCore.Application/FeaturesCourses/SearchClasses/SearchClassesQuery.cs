using MediatR;
using SampleUniversityCore.Application.Services.DTOs;

namespace SampleUniversityCore.Application.FeaturesCourses.SearchClasses;

public class SearchClassesQuery : IRequest<ResultDTO<List<CourseSectionDetailDTO>>>
{
    public required List<SearchCourseSectionClassesDTO> Search { get; set; }
}