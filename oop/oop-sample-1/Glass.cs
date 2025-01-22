namespace oop_sample_1;

public class Glass
{
    private decimal _waterCapacityml;
    private decimal _waterContentml = 0;

    public Glass(decimal waterCapacityml)
    {
        _waterCapacityml = waterCapacityml;
    }

    public decimal WaterContentml { get => _waterContentml; set => _waterContentml = value; }

    public void FillWater()
    {
        _waterContentml = _waterCapacityml;
    }

    public void DrinkWater()
    {
        if (_waterContentml == 0)
        {
            throw new Exception("No water to drink");
        }
        EmptyWater();
    }

    private void EmptyWater()
    {
        _waterContentml = 0;
    }
}
