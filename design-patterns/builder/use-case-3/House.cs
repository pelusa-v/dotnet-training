namespace UseCase3;

/// <summary>
/// Product class representing a House
/// </summary>
public class House
{
    public string? Foundation { get; set; }
    public string? Structure { get; set; }
    public string? Roof { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public bool HasGarage { get; set; }
    public bool HasGarden { get; set; }
    public bool HasSwimmingPool { get; set; }
    public string? InteriorFinish { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine("House Details:");
        Console.WriteLine($"  Foundation: {Foundation ?? "Not specified"}");
        Console.WriteLine($"  Structure: {Structure ?? "Not specified"}");
        Console.WriteLine($"  Roof: {Roof ?? "Not specified"}");
        Console.WriteLine($"  Bedrooms: {Bedrooms}");
        Console.WriteLine($"  Bathrooms: {Bathrooms}");
        Console.WriteLine($"  Interior Finish: {InteriorFinish ?? "Not specified"}");
        Console.WriteLine($"  Garage: {(HasGarage ? "Yes" : "No")}");
        Console.WriteLine($"  Garden: {(HasGarden ? "Yes" : "No")}");
        Console.WriteLine($"  Swimming Pool: {(HasSwimmingPool ? "Yes" : "No")}");
        Console.WriteLine();
    }
}
