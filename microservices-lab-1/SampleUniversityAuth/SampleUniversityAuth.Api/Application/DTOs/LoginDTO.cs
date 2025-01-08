namespace SampleUniversityAuth.Api.Application.DTOs;

public class LoginDTO
{
    public required string Password { get; set; }
    public required string Email { get; set; }
}
