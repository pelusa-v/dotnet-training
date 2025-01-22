namespace oop_sample_2;

public interface IDrinkableContainer
{
    void Fill();
    void Fill(decimal liquidml);

    void Drink();

    decimal RemainingCapacityml { get; }
    decimal Capacityml { get; }
    decimal Contentml { get; }
}
