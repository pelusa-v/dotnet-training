using Microsoft.AspNetCore.Identity;

namespace SampleUniversityAuth.Api.DataAccess.Entities;

public class User : IdentityUser
{
    public string FullName { get; set; } = null!;
}
