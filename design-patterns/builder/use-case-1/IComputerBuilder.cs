namespace UseCase1;

/// <summary>
/// Abstract Builder interface for building a Computer
/// </summary>
public interface IComputerBuilder
{
    void BuildCPU();
    void BuildRAM();
    void BuildStorage();
    void BuildGPU();
    void BuildOperatingSystem();
    void BuildWiFi();
    void BuildBluetooth();
    Computer GetComputer();
}
