using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class CourseClass : BaseEntity
{
    public int CourseSectionId { get; set; }
    public CourseSection CourseSection { get; } = null!;
    public int TeacherId { get; set; }
    public Teacher Teacher { get; } = null!;
    public int ClassTypeId { get; set; }
    public ClassType ClassType { get; } = null!;

    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DayOfWeek Day { get; set; }
}
