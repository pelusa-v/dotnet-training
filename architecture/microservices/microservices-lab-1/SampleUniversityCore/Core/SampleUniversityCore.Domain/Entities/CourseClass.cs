using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Domain.Entities;

public class CourseClass : BaseEntity
{
    public int CourseSectionId { get; set; }
    public CourseSection CourseSection { get; set; } = null!;
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; } = null!;
    public int ClassTypeId { get; set; }
    public ClassType ClassType { get; set; } = null!;

    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DayOfWeek Day { get; set; }
}
