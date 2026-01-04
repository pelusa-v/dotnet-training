namespace UseCase3;

/// <summary>
/// Concrete Builder for building a Small Apartment
/// </summary>
public class ApartmentBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildFoundation()
    {
        _house.Foundation = "Part of larger building structure";
    }

    public void BuildStructure()
    {
        _house.Structure = "Concrete apartment unit";
    }

    public void BuildRoof()
    {
        _house.Roof = "Shared building roof";
    }

    public void BuildBedrooms()
    {
        _house.Bedrooms = 2;
    }

    public void BuildBathrooms()
    {
        _house.Bathrooms = 1;
    }

    public void BuildGarage()
    {
        _house.HasGarage = false;
    }

    public void BuildGarden()
    {
        _house.HasGarden = false;
    }

    public void BuildSwimmingPool()
    {
        _house.HasSwimmingPool = false;
    }

    public void BuildInterior()
    {
        _house.InteriorFinish = "Tile flooring, compact layout";
    }

    public House GetHouse()
    {
        return _house;
    }
}
