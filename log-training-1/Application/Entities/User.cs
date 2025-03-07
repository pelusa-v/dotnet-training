namespace log_training_1;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Beast> Beasts { get; set; } = new List<Beast>();
}
