namespace SampleUniversityAuth.Api.Application.DTOs;

public class CreatedUserDTO
{
    public required string Id { get; set; }
    public required string Email { get; set; }
    public required string FullName { get; set; }
}
