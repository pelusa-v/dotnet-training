namespace use_case_1;

public class Airplane
{
    public string Code { get; }
    public string Name { get; }
    public string Airline { get; set; }
    private ControlTower _controlTower;

    public Airplane(string code, string name, string airline, ControlTower controlTower)
    {
        Code = code;
        Name = name;
        Airline = airline;
        _controlTower = controlTower;
    }

    public void JoinControlTower()
    {
        _controlTower.RegisterAirplane(this);
    }

    public void Land()
    {
        if (_controlTower.ValidateLanding(this))
        {
            _controlTower.StartLanding(this);
        }
    }
}
