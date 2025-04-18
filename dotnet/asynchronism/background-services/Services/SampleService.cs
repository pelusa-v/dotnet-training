namespace background_services.Services;

public class SampleService
{
    private readonly CancelableBackgroundService _simpleBackgroundService;

    public SampleService(CancelableBackgroundService simpleBackgroundService)
    {
        _simpleBackgroundService = simpleBackgroundService;
    }

    public void StopBackgroundService()
    {
        _simpleBackgroundService.StopServiceFromOutside();
    }
}
