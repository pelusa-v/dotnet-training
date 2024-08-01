namespace Api;

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string Content { get; set; }
}
