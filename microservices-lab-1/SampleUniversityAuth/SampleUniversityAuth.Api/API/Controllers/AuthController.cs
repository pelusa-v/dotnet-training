using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleUniversityAuth.Api.Application;
using SampleUniversityAuth.Api.Application.DTOs;
using SampleUniversityAuth.Api.DataAccess.Entities;

namespace SampleUniversityAuth.Api.Controllers;

public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<CreatedUserDTO>> Register([FromBody] RegisterDTO request)
    {
        var createdUser = await _authService.Register(request);
        if (createdUser == null)
        {
            return BadRequest("User could not be created");
        }
        return Ok(createdUser);
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoggedUserDTO>> Login([FromBody] LoginDTO request)
    {
        var loggedUser = await _authService.Login(request);
        if (loggedUser == null)
        {
            return BadRequest("Invalid email or password");
        }
        return Ok(loggedUser);
    }
}
