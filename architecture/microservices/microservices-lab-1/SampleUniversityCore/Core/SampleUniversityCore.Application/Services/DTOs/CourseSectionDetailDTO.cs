namespace SampleUniversityCore.Application.Services.DTOs;

public class CourseSectionDetailDTO
{
    public CourseDTO Course { get; set; } = null!;
    public SectionDTO Section { get; set; } = null!;

    public ICollection<CourseClassDTO> CourseClasses { get; set; } = new List<CourseClassDTO>();
}
