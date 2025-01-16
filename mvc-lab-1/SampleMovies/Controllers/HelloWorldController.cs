using Microsoft.AspNetCore.Mvc;

namespace SampleMovies.Controllers;

// Controller: Base class with View support (used in mvc apps)
// ControllerBase: Base class without View support (used in webapi)
public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SayHello(string name, int hits = 1)
    {
        ViewData["Message"] = $"Hello {name}";
        ViewData["Hits"] = hits;
        return View();
    }
}
