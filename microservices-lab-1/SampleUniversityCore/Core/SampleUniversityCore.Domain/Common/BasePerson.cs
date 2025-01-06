namespace SampleUniversityCore.Domain.Common;

public class BasePerson : BaseEntity
{
    public int UserId { get; set; }
    public string FullName { get; set; } = null!;
}
