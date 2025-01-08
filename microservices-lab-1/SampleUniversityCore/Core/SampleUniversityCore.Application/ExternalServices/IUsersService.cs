namespace SampleUniversityCore.Application.ExternalServices;

public interface IUsersService
{
    Task<string> CreateUser(CreateUserDTO user);
}
