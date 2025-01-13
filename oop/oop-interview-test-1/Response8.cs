namespace oop_interview_test_1;

public abstract class Vehicle
{
    public abstract void StartEngine();
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car Engine Started");
    }
}

public class Truck : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Truck Engine Started");
    }
}