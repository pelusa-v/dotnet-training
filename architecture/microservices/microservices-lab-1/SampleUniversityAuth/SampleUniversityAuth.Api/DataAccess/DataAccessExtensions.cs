using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SampleUniversityAuth.Api.DataAccess.Entities;

namespace SampleUniversityAuth.Api.DataAccess;

public static class DataAccessExtensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });

        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        return services;
    }
}
