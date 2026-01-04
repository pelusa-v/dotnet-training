namespace UseCase1;

/// <summary>
/// Director class that orchestrates the building process
/// </summary>
public class ComputerDirector
{
    private IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructComputer()
    {
        _builder.BuildCPU();
        _builder.BuildRAM();
        _builder.BuildStorage();
        _builder.BuildGPU();
        _builder.BuildOperatingSystem();
        _builder.BuildWiFi();
        _builder.BuildBluetooth();
    }

    public Computer GetComputer()
    {
        return _builder.GetComputer();
    }
}
