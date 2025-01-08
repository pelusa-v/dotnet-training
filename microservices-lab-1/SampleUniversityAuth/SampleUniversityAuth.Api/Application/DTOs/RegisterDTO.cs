namespace SampleUniversityAuth.Api.Application.DTOs;

public class RegisterDTO
{
    public required string Password { get; set; }
    public required string Email { get; set; }
    public required string FullName { get; set; }
    public required string Role { get; set; }
    public string Username { get => Email; }
}
