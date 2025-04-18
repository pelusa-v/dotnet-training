using Refit;

namespace SampleUniversityCore.External.APIs;

public interface IUsersApi
{
    [Post("/api/auth/register")]
    Task<RegisterResponse> RegisterAsync([Body] RegisterRequest request);
}
