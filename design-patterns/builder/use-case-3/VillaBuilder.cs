namespace UseCase3;

/// <summary>
/// Concrete Builder for building a Luxury Villa
/// </summary>
public class VillaBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildFoundation()
    {
        _house.Foundation = "Reinforced concrete with deep piles";
    }

    public void BuildStructure()
    {
        _house.Structure = "Steel and reinforced concrete, 2 stories";
    }

    public void BuildRoof()
    {
        _house.Roof = "Spanish tile roof";
    }

    public void BuildBedrooms()
    {
        _house.Bedrooms = 5;
    }

    public void BuildBathrooms()
    {
        _house.Bathrooms = 4;
    }

    public void BuildGarage()
    {
        _house.HasGarage = true;
    }

    public void BuildGarden()
    {
        _house.HasGarden = true;
    }

    public void BuildSwimmingPool()
    {
        _house.HasSwimmingPool = true;
    }

    public void BuildInterior()
    {
        _house.InteriorFinish = "Marble floors, high-end appliances, custom cabinetry";
    }

    public House GetHouse()
    {
        return _house;
    }
}
