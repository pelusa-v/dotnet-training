namespace oop_sample_2;

public class ThirstyHuman
{
    private string _name;
    private WaterSource _source;
    private IDrinkableContainer _liquidContainer;


    public ThirstyHuman(string name, WaterSource source, IDrinkableContainer liquidContainer)
    {
        _name = name;
        GrabUtensils(source, liquidContainer);
    }

    public void GrabUtensils(WaterSource source, IDrinkableContainer liquidContainer)
    {
        _liquidContainer = liquidContainer;
        _source = source;
        Console.WriteLine($"{_name} is grabbing a utensil");
    }

    public void Drink()
    {
        Console.WriteLine($"{_name} is pouring liquid into the container");
        _source.FillContainer(_liquidContainer);
        Console.WriteLine($"{_name} is drinking {_liquidContainer.Contentml} ml of liquid from the container");
        _liquidContainer.Drink();
        Console.WriteLine($"{_name} has finished drinking liquid");
    }
}
