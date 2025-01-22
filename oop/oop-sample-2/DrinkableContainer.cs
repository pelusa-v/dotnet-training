namespace oop_sample_2;

public class DrinkableContainer : LiquidContainer, IDrinkableContainer
{
    public DrinkableContainer(decimal capacityml) : base(capacityml)
    {
        _contentml = 0;
    }

    public void Fill()
    {
        _contentml = _capacityml;
    }

    public void Fill(decimal liquidml)
    {
        _contentml += liquidml;
    }

    public void Drink()
    {
        DropLiquid();
    }

    public void Try()
    {
        Fill();
        Drink();
    }
}
