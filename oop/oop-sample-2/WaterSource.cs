namespace oop_sample_2;

public class WaterSource : LiquidContainer
{
    private bool _infinitelyAvailable = false;

    public WaterSource(bool infinite) : base(decimal.MaxValue)
    {
        _infinitelyAvailable = infinite;
        _contentml = decimal.MaxValue;
    }

    public WaterSource(decimal capacityml) : base(capacityml)
    {
        _contentml = capacityml;
    }

    public override void DropLiquid(decimal liquidml)
    {
        if (!_infinitelyAvailable)
            base.DropLiquid(liquidml);
    }

    public void FillContainer(IDrinkableContainer container)
    {
        if (_contentml <= container.RemainingCapacityml)
        {
            DropLiquid(_contentml);
            container.Fill(_contentml);
        }
        else
        {
            DropLiquid(container.RemainingCapacityml);
            container.Fill();
        }
    }
}
