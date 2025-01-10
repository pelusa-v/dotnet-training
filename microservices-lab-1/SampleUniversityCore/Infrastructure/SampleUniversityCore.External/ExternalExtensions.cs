using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using SampleUniversityCore.Application.ExternalServices;
using SampleUniversityCore.External.APIs;

namespace SampleUniversityCore.External;

public static class ExternalExtensions
{
    public static void AddExternalServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUsersService, UserService>();
        services.AddHttpClient<TokenApi>(client =>  client.BaseAddress = new Uri("http://localhost:5167"));
        
        // External APIs
        services.AddTransient<AuthHandler>();

        services.AddRefitClient<IUsersApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:5167"))
            .AddHttpMessageHandler<AuthHandler>();
    }
}
