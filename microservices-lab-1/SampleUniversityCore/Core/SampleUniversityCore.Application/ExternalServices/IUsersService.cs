using SampleUniversityCore.Domain.Enums;

namespace SampleUniversityCore.Application.ExternalServices;

public interface IUsersService
{
    Task<string> CreateUser(CreateUserDTO user, Role role);
    Task<string> CreateTeacherUser(CreateUserDTO user);
    Task<string> CreateStudentUser(CreateUserDTO user);
}
