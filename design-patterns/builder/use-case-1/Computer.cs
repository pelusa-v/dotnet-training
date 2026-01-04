namespace UseCase1;

/// <summary>
/// Product class representing a Computer with multiple components
/// </summary>
public class Computer
{
    public string? CPU { get; set; }
    public string? RAM { get; set; }
    public string? Storage { get; set; }
    public string? GPU { get; set; }
    public string? OperatingSystem { get; set; }
    public bool HasWiFi { get; set; }
    public bool HasBluetooth { get; set; }

    public void DisplaySpecifications()
    {
        Console.WriteLine("Computer Specifications:");
        Console.WriteLine($"  CPU: {CPU ?? "Not specified"}");
        Console.WriteLine($"  RAM: {RAM ?? "Not specified"}");
        Console.WriteLine($"  Storage: {Storage ?? "Not specified"}");
        Console.WriteLine($"  GPU: {GPU ?? "Not specified"}");
        Console.WriteLine($"  Operating System: {OperatingSystem ?? "Not specified"}");
        Console.WriteLine($"  WiFi: {(HasWiFi ? "Yes" : "No")}");
        Console.WriteLine($"  Bluetooth: {(HasBluetooth ? "Yes" : "No")}");
        Console.WriteLine();
    }
}
