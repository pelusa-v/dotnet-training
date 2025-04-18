using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SampleUniversityAuth.Api.Application.DTOs;
using SampleUniversityAuth.Api.DataAccess.Entities;

namespace SampleUniversityAuth.Api.Application;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public AuthService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
        _roleManager = roleManager;
    }

    public async Task<LoggedUserDTO?> Login(LoginDTO loginDTO)
    {
        var user = await _userManager.FindByEmailAsync(loginDTO.Email);

        if (user == null)
            return null;

        var result = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);

        if (result.Succeeded)
        {
            var token = GenerateJwtToken(user);
            return new LoggedUserDTO { Token = token };
        }

        return null;
    }

    public async Task<CreatedUserDTO?> Register(RegisterDTO registerDTO)
    {
        var role = await _roleManager.FindByNameAsync(registerDTO.Role);
        if (role == null || role.Name == null)
            return null;
        
        var user = _mapper.Map<User>(registerDTO);
        var result = await _userManager.CreateAsync(user, registerDTO.Password);
        if (!result.Succeeded)
            return null;
        
        await _userManager.AddToRoleAsync(user, role.Name);
        return _mapper.Map<CreatedUserDTO>(user);
    }

    private string GenerateJwtToken(User user)
    {
        var jwtConfig = _configuration.GetSection("Jwt");
        var a = jwtConfig["key"];
        var secretKey = Encoding.UTF8.GetBytes(jwtConfig["key"] ?? "");
        var audience = jwtConfig["audience"] ?? "";
        var issuer = jwtConfig["issuer"] ?? "";

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.FullName)
        };

        _userManager.GetRolesAsync(user).Result.ToList().ForEach(role =>
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        });

        var key = new SymmetricSecurityKey(secretKey);
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTime.Now.AddDays(1);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: expires,
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
