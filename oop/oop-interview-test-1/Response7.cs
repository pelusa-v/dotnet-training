namespace oop_interview_test_1;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string ISBN { get; set; }
}

public class AudioBook : Book
{
    public string Narrator { get; set; }
    public string Length { get; set; }
}

public class EBook : Book
{
    public string Format { get; set; }
    public string Size { get; set; }
}