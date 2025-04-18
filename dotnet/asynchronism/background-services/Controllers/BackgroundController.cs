using background_services.Services;
using Microsoft.AspNetCore.Mvc;

namespace background_services.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BackgroundController : ControllerBase
{
    private readonly SampleService _sampleService;

    public BackgroundController(SampleService sampleService)
    {
        _sampleService = sampleService;
    }

    [HttpGet("stop")]
    public IActionResult StopBackgroundService()
    {
        _sampleService.StopBackgroundService();
        return Ok("Background service stopped.");
    }
}