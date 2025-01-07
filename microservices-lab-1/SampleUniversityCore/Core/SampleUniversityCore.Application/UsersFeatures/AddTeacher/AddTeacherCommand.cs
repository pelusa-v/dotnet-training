using MediatR;

namespace SampleUniversityCore.Application.UsersFeatures.AddTeacher;

public class AddTeacherCommand : IRequest<AddTeacherDTO>
{
    public required string FullName { get; set; }
}
