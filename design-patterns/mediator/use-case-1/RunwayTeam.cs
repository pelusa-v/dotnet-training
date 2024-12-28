namespace use_case_1;

public class RunwayTeam
{
    public Dictionary<int, bool> Runways { get; } = new Dictionary<int, bool>();
    private ControlTower _controlTower;

    public RunwayTeam(Dictionary<int, bool> runways, ControlTower controlTower)
    {
        Runways = runways;
        _controlTower = controlTower;
    }

    public bool FreeRunway()
    {
        return Runways.Any(r => !r.Value);
    }
}
