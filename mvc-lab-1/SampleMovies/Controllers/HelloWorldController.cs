using Microsoft.AspNetCore.Mvc;

namespace SampleMovies.Controllers;

// Controller: Base class with View support (used in mvc apps)
// ControllerBase: Base class without View support (used in webapi)
public class HelloWorldController : Controller
{
    public string Index()
    {
        return "Default action";
    }

    public string SayHello(string name, string lastName, int id = 1)
    {
        return $"Hello, {name} {lastName}, ID: {id}";
    }
}
