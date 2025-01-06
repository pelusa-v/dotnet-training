using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class Course : BaseEntity
{
    public Guid Code { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int Credits { get; set; }

    public ICollection<CourseSection> CourseSection { get; } = new List<CourseSection>();
}
