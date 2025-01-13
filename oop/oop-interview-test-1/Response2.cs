namespace oop_interview_test_1;


public class SpaceAngar
{
    // Encapsulation and Abstraction
    public void DepartSpaceShip(IFlyingShip spaceShip)  // Abstraction
    {
        spaceShip.Depart();
    }
}

public class StarPlane : IFlyingShip  // Abstraction
{
    // Encapsulation
    public void Depart()
    {
        Console.WriteLine("StarPlane Departed");
    }
}

public class ColossalRocket : IFlyingShip  // Abstraction
{
    // Encapsulation
    public void Depart()
    {
        Console.WriteLine("ColossalRocket Departed");
    }
}

public interface IFlyingShip
{
    // Encapsulation
    void Depart();
}