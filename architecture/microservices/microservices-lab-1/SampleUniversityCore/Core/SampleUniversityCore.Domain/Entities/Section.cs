using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class Section : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<CourseSection> CourseSection { get; } = new List<CourseSection>();
}
