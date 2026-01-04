namespace UseCase3;

/// <summary>
/// Abstract Builder interface for building a House
/// </summary>
public interface IHouseBuilder
{
    void BuildFoundation();
    void BuildStructure();
    void BuildRoof();
    void BuildBedrooms();
    void BuildBathrooms();
    void BuildGarage();
    void BuildGarden();
    void BuildSwimmingPool();
    void BuildInterior();
    House GetHouse();
}
