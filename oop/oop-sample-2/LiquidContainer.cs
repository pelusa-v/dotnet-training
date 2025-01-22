namespace oop_sample_2;

public abstract class LiquidContainer
{
    protected decimal _capacityml;
    protected decimal _contentml;

    public decimal Capacityml { get => _capacityml; }
    public decimal Contentml { get => _contentml; }
    public decimal RemainingCapacityml { get => _capacityml - _contentml; }

    protected LiquidContainer(decimal capacityml, decimal contentml)
    {
        _capacityml = capacityml;
        _contentml = contentml;
    }

    public LiquidContainer(decimal capacityml)
    {
        _capacityml = capacityml;
    }

    public virtual void DropLiquid(decimal liquidml)
    {
        if (_contentml < liquidml)
        {
            throw new NotEnoughLiquidException("Not enough liquid to drop");
        }
        _contentml -= liquidml;
    }

    public void DropLiquid()
    {
        if (_contentml == 0)
        {
            throw new NotLiquidException("No liquid");
        }
        _contentml = 0;
    }
}


public class NotEnoughLiquidException : Exception
{
    public NotEnoughLiquidException(string message) : base(message)
    {
    }
}

public class NotLiquidException : Exception
{
    public NotLiquidException(string message) : base(message)
    {
    }
}