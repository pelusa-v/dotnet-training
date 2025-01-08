using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SampleUniversityAuth.Api.DataAccess.Entities;

namespace SampleUniversityAuth.Api.Controllers;

public class AuthController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IConfiguration _configuration;

    public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    // [HttpPost("register")]
    // public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    // {
    //     var user = new User
    //     {
    //         UserName = request.Email,
    //         Email = request.Email,
    //         FullName = request.FullName
    //     };

    //     var result = await _userManager.CreateAsync(user, request.Password);

    //     if (result.Succeeded)
    //     {
    //         return Ok();
    //     }

    //     return BadRequest(result.Errors);
    // }

    // [HttpPost("login")]
    // public async Task<IActionResult> Login([FromBody] LoginRequest request)
    // {
    //     var user = await _userManager.FindByEmailAsync(request.Email);

    //     if (user == null)
    //     {
    //         return BadRequest("Invalid email or password");
    //     }

    //     var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

    //     if (result.Succeeded)
    //     {
    //         var token = GenerateJwtToken(user);

    //         return Ok(new { token });
    //     }

    //     return BadRequest("Invalid email or password");
    // }

    // private string GenerateJwtToken(User user)
    // {
    //     var jwtConfig = _configuration.GetSection("Jwt");
    //     var secretKey = Encoding.UTF8.GetBytes(jwtConfig["key"] ?? "");
    //     var audience = jwtConfig["audience"] ?? "";
    //     var issuer = jwtConfig["issuer"] ?? "";

    //     var claims = new List<Claim>
    //     {
    //         new Claim(ClaimTypes.NameIdentifier, user.Id),
    //         new Claim(ClaimTypes.Name, user.UserName)
    //     };

    //     var key = new SymmetricSecurityKey(secretKey);
    //     var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
    //     var expires = DateTime.Now.AddDays(1);

    //     var token = new JwtSecurityToken(
    //         issuer: issuer,
    //         audience: audience,
    //         claims: claims,
    //         expires: expires,
    //         signingCredentials: credentials
    //     );

    //     return new JwtSecurityTokenHandler().WriteToken(token);
    // }
}
