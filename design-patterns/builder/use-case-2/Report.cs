namespace UseCase2;

/// <summary>
/// Product class representing a Report
/// </summary>
public class Report
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime? Date { get; set; }
    public string? Content { get; set; }
    public string? Footer { get; set; }
    public string? Format { get; set; }
    public bool IncludeTableOfContents { get; set; }
    public bool IncludePageNumbers { get; set; }

    public void Display()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"Title: {Title ?? "Untitled Report"}");
        Console.WriteLine($"Author: {Author ?? "Unknown"}");
        Console.WriteLine($"Date: {Date?.ToString("yyyy-MM-dd") ?? "Not specified"}");
        Console.WriteLine($"Format: {Format ?? "Not specified"}");
        Console.WriteLine($"Table of Contents: {(IncludeTableOfContents ? "Yes" : "No")}");
        Console.WriteLine($"Page Numbers: {(IncludePageNumbers ? "Yes" : "No")}");
        Console.WriteLine("========================================");
        Console.WriteLine("Content:");
        Console.WriteLine(Content ?? "No content");
        Console.WriteLine("========================================");
        if (!string.IsNullOrEmpty(Footer))
        {
            Console.WriteLine($"Footer: {Footer}");
            Console.WriteLine("========================================");
        }
        Console.WriteLine();
    }
}
