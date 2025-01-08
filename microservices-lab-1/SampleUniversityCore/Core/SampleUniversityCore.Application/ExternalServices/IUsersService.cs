namespace SampleUniversityCore.Application.ExternalServices;

public interface IUsersService
{
    Task<int> CreateUser(CreateUserDTO user);
}
