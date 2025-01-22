namespace oop_sample_2;

public class WaterSource
{
    private LiquidContainer? _internalContainer = null;

    private bool InfinitelyAvailable() => _internalContainer == null;

    public WaterSource()
    {
    }

    public WaterSource(LiquidContainer container)
    {
        _internalContainer = container;
    }

    public void FillContainer(IDrinkableContainer container)
    {
        if (InfinitelyAvailable())
        {
            container.Fill();
            return;
        }
        
        var availableLiquid = _internalContainer.Contentml;
        if (_internalContainer.Contentml <= container.RemainingCapacityml)
        {
            _internalContainer.DropLiquid(availableLiquid);
            container.Fill(availableLiquid);
        }
        else
        {
            _internalContainer.DropLiquid(container.RemainingCapacityml);
            container.Fill();
        }
    }
}
