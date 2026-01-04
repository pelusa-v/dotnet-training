namespace UseCase3;

/// <summary>
/// Concrete Builder for building a Standard Family House
/// </summary>
public class FamilyHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildFoundation()
    {
        _house.Foundation = "Concrete slab foundation";
    }

    public void BuildStructure()
    {
        _house.Structure = "Wood frame, single story";
    }

    public void BuildRoof()
    {
        _house.Roof = "Asphalt shingle roof";
    }

    public void BuildBedrooms()
    {
        _house.Bedrooms = 3;
    }

    public void BuildBathrooms()
    {
        _house.Bathrooms = 2;
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
        _house.HasSwimmingPool = false;
    }

    public void BuildInterior()
    {
        _house.InteriorFinish = "Laminate flooring, standard appliances";
    }

    public House GetHouse()
    {
        return _house;
    }
}
