namespace UseCase1;

/// <summary>
/// Concrete Builder for building an Office Computer
/// </summary>
public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "Intel Core i5-12400";
    }

    public void BuildRAM()
    {
        _computer.RAM = "16GB DDR4";
    }

    public void BuildStorage()
    {
        _computer.Storage = "512GB SSD";
    }

    public void BuildGPU()
    {
        _computer.GPU = "Integrated Graphics";
    }

    public void BuildOperatingSystem()
    {
        _computer.OperatingSystem = "Windows 11 Home";
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
