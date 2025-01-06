using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class Teacher : BasePerson
{
    public ICollection<CourseClass> CourseClasses { get; } = new List<CourseClass>();
}
