namespace oop_sample_1;

public class Human
{
    private string _name;

    public Human(string name)
    {
        _name = name;
    }

    public void DrinkWater(WaterSource source, Glass glass)
    {
        Console.WriteLine($"{_name} is pouring water into the glass");
        source.FillWater(glass);
        Console.WriteLine($"{_name} is drinking {glass.WaterContentml} ml of water from the glass");
        glass.DrinkWater();
        Console.WriteLine($"{_name} has finished drinking water");
    }
}
