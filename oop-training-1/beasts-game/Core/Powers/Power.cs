namespace beasts_game.Core.Powers;

public abstract class Power
{
    public string Name { get; set; }
    public string Description { get; set; }
    public abstract string ActionDescription { get; }

    public Power(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public abstract void Use(Beast self, Beast target = null);
}