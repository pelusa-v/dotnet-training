using Airport.Domain;

namespace Airport.Application;

public class FlightService : IFlightService
{
    private readonly IPlaneRepository _planeRepository;

    public FlightService(IPlaneRepository planeRepository)
    {
        _planeRepository = planeRepository;
    }
}
