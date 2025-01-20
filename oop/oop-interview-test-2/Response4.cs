namespace oop_interview_test_2;

public class Bottle
{
    public ILiquid Content { get; private set; }

    public void Fill(ILiquid content)
    {
        Content = content;
        content.Sound();
    }
}

public interface ILiquid
{
    void Sound();
}

public class Soda : ILiquid
{
    public void Sound()
    {
        Console.WriteLine("Fizz");
    }
}

public class Water : ILiquid
{
    public void Sound()
    {
        Console.WriteLine("Splash");
    }
}


// WITHOUT SOLID PRINCIPLES
public class BadBottle
{
    public object Content { get; private set; }

    public void Fill(object content)
    {
        if (content is BadSoda)
        {
            Console.WriteLine("Fizz");
        }
        else if (content is BadWater)
        {
            Console.WriteLine("Splash");
        }
        Content = content;
    }
}

public class BadSoda
{
}

public class BadWater
{
}
