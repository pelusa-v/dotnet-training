using SampleUniversityCore.Application.FeaturesUsers.AddTeacher;

namespace SampleUniversityCore.Application.Services.DTOs;

public class CourseClassDTO
{
    public int Id { get; set; }
    public TeacherDTO Teacher { get; set; } = null!;
    public ClassTypeDTO ClassType { get; set; } = null!;

    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DayOfWeek Day { get; set; }
}
