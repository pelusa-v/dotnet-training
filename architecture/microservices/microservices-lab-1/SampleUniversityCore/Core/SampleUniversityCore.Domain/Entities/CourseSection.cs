using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class CourseSection : BaseEntity
{
    public int CourseId { get; set; }
    public int SectionId { get; set; }
    public Course Course { get; set; } = null!;
    public Section Section { get; set; } = null!;

    public ICollection<CourseClass> CourseClasses { get; } = new List<CourseClass>();
}
