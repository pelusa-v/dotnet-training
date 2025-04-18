using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class ClassType : BaseEntity
{
    public string Name { get; set; } = null!;

    public ICollection<CourseClass> CourseClasses { get; } = new List<CourseClass>();
}
