namespace oop_sample_2;

public class Bottle : LiquidContainer
{
    public Bottle(decimal capacityml) : base(capacityml)
    {
        _contentml = capacityml;
    }
}
