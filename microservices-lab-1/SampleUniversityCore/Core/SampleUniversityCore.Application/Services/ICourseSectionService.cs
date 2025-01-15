using SampleUniversityCore.Application.Services.DTOs;

namespace SampleUniversityCore.Application;

public interface ICourseSectionService
{
    Task GetCourseSectionDetailAsync();
    Task CraeateCourseSectionAsync();
    Task<ResultDTO<List<CourseSectionDetailDTO>>> SearchCourseSectionClassesAsync(List<SearchCourseSectionClassesDTO> search);
}
