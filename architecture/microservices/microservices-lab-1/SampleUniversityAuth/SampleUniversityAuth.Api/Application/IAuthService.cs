using Microsoft.AspNetCore.Http.HttpResults;
using SampleUniversityAuth.Api.Application.DTOs;

namespace SampleUniversityAuth.Api.Application;

public interface IAuthService
{
    Task<CreatedUserDTO?> Register(RegisterDTO registerDTO);
    Task<LoggedUserDTO?> Login(LoginDTO loginDTO);
}
