namespace oop_interview_test_1;

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return 0.5 * Base * Height;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return Width * Height;
    }
}