namespace SampleUniversityCore.Domain.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
}
