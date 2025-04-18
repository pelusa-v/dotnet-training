namespace SampleUniversityCore.Domain.Common;

public class BasePerson : BaseEntity
{
    public string UserId { get; set; } = null!;
    public string FullName { get; set; } = null!;
}
