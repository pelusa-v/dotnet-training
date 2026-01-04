namespace UseCase3;

/// <summary>
/// Director class that orchestrates the house building process
/// </summary>
public class ConstructionEngineer
{
    private IHouseBuilder _builder;

    public ConstructionEngineer(IHouseBuilder builder)
    {
        _builder = builder;
    }

    /// <summary>
    /// Construct a complete house with all features
    /// </summary>
    public void ConstructFullHouse()
    {
        _builder.BuildFoundation();
        _builder.BuildStructure();
        _builder.BuildRoof();
        _builder.BuildBedrooms();
        _builder.BuildBathrooms();
        _builder.BuildGarage();
        _builder.BuildGarden();
        _builder.BuildSwimmingPool();
        _builder.BuildInterior();
    }

    /// <summary>
    /// Construct a minimal house without extras
    /// </summary>
    public void ConstructMinimalHouse()
    {
        _builder.BuildFoundation();
        _builder.BuildStructure();
        _builder.BuildRoof();
        _builder.BuildBedrooms();
        _builder.BuildBathrooms();
        _builder.BuildInterior();
    }

    public House GetHouse()
    {
        return _builder.GetHouse();
    }
}
