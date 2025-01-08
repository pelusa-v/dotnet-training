using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace SampleUniversityAuth.Api.Application;

public static class ApplicationExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        // var jwtConfig = configuration.GetSection("Jwt");
        // var secretKey = Encoding.UTF8.GetBytes(jwtConfig["key"] ?? "");
        // var audience = jwtConfig["audience"] ?? "";
        // var issuer = jwtConfig["issuer"] ?? "";

        // services.AddAuthentication(options =>
        // {
        //     options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //     options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        // })
        // .AddJwtBearer(options =>
        // {
        //     options.TokenValidationParameters = new TokenValidationParameters
        //     {
        //         ValidateIssuer = true,
        //         ValidateAudience = true,
        //         ValidateLifetime = true,
        //         ValidateIssuerSigningKey = true,
        //         ValidIssuer = issuer,
        //         ValidAudience = audience,
        //         IssuerSigningKey = new SymmetricSecurityKey(secretKey)
        //     };
        // });
        return services;
    }
}
