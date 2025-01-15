namespace SampleUniversityCore.Application.Services.DTOs;

public class CourseDTO
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public required string Name { get; set; }
}
