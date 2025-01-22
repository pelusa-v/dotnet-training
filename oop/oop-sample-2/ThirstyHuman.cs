namespace oop_sample_2;

public class ThirstyHuman
{
    private string _name;
    
    public ThirstyHuman(string name)
    {
        _name = name;
    }

    public void Drink(WaterSource source, IDrinkableContainer liquidContainer)
    {
        Console.WriteLine($"{_name} is pouring liquid into the container");
        source.FillContainer(liquidContainer);
        Console.WriteLine($"{_name} is drinking {liquidContainer.Contentml} ml of liquid from the container");
        liquidContainer.Drink();
        Console.WriteLine($"{_name} has finished drinking liquid");
    }
}
