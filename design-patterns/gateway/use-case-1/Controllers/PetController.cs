using Microsoft.AspNetCore.Mvc;
using use_case_1.DTOs;
using use_case_1.Services;

namespace use_case_1;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    [HttpGet("search")]
    public async Task<ActionResult<List<PetDTO>>> SearchPetAsync(string name)
    {
        var pets = await _petService.SearchPetAsync(name);
        return Ok(pets);
    }
}
