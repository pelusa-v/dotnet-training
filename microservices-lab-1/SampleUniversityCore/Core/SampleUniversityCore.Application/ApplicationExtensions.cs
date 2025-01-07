using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SampleUniversityCore.Application.Repositories;

namespace SampleUniversityCore.Application;

public static class ApplicationExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(UsersMapper));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}
