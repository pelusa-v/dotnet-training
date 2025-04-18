using Microsoft.AspNetCore.Mvc;

namespace log_training_1;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly BeastsService _beastsService = null!;

    public UsersController(BeastsService beastsService)
    {
        _beastsService = beastsService;
    }

    [HttpPost("{userId}/beasts/{beastId}/capture")]
    public ActionResult<User> CaptureBeast(int beastId, int userId)
    {
        var user = _beastsService.CaptureBeast(beastId, userId);
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }
}
