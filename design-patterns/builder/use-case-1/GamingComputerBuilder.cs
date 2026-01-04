namespace UseCase1;

/// <summary>
/// Concrete Builder for building a Gaming Computer
/// </summary>
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "Intel Core i9-13900K";
    }

    public void BuildRAM()
    {
        _computer.RAM = "32GB DDR5";
    }

    public void BuildStorage()
    {
        _computer.Storage = "2TB NVMe SSD";
    }

    public void BuildGPU()
    {
        _computer.GPU = "NVIDIA RTX 4090";
    }

    public void BuildOperatingSystem()
    {
        _computer.OperatingSystem = "Windows 11 Pro";
    }

    public void BuildWiFi()
    {
        _computer.HasWiFi = true;
    }

    public void BuildBluetooth()
    {
        _computer.HasBluetooth = true;
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}
