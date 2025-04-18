using SampleUniversityCore.Application.ExternalServices;
using SampleUniversityCore.Domain.Enums;
using SampleUniversityCore.External.APIs;

namespace SampleUniversityCore.External;

public class UserService : IUsersService
{
    private readonly IUsersApi _usersApi;

    public UserService(IUsersApi usersApi)
    {
        _usersApi = usersApi;
    }

    public async Task<string> CreateTeacherUser(CreateUserDTO user)
    {
        return await CreateUser(user, Role.teacher);
    }

    public async Task<string> CreateStudentUser(CreateUserDTO user)
    {
        return await CreateUser(user, Role.student);
    }

    public async Task<string> CreateUser(CreateUserDTO user, Role role)
    {
        var registerRes = await _usersApi.RegisterAsync(new RegisterRequest
        {
            Email = user.Email,
            Password = user.Password,
            FullName = user.FullName,
            Role = role.ToString()
        });

        if (registerRes == null)
        {
            throw new Exception("Failed to create user");
        }

        return registerRes.Id;
    }
}
