using MediatR;

namespace SampleUniversityCore.Application.UsersFeatures.AddTeacher;

public class AddTeacherCommand : IRequest<AddTeacherDTO>
{
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}
