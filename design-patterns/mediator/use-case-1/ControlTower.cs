namespace use_case_1;

public class ControlTower
{
    public Dictionary<Airplane, int?> AirplanesRunways { get; } = new Dictionary<Airplane, int?>();
    public RunwayTeam RunwayTeam { get;}

    public ControlTower(RunwayTeam runwayTeam)
    {
        RunwayTeam = runwayTeam;
    }

    public void RegisterAirplane(Airplane airplane)
    {
        AirplanesRunways.Add(airplane, null);
    }

    public bool ValidateLanding(Airplane airplane)
    {
        if (RunwayTeam.FreeRunway())
        {
            Console.WriteLine($"No runway available for airplane {airplane.Code}.");
            return false;
        }
        return true;
    }

    public void StartLanding(Airplane airplane)
    {
        var runway = RunwayTeam.Runways.First(r => !r.Value).Key;
        RunwayTeam.Runways[runway] = true;
        AirplanesRunways[airplane] = runway;
        NotifyLanding(airplane);
    }

    public void NotifyLanding(Airplane airplane)
    {
        foreach (var airplaneRunway in AirplanesRunways)
        {
            if (airplaneRunway.Key.Code != airplane.Code)
            {
                Console.WriteLine($"Airplane {airplane.Code} will land on runway {airplaneRunway.Value}.");
            }
        }
    }
}
