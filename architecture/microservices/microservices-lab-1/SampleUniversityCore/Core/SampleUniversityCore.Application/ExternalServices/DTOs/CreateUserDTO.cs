using SampleUniversityCore.Domain.Enums;

namespace SampleUniversityCore.Application.ExternalServices;

public class CreateUserDTO
{
    public required string FullName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
}
