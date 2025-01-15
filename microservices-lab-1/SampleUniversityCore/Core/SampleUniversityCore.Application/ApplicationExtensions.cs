using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SampleUniversityCore.Application.Services;
using SampleUniversityCore.Application.Validators;

namespace SampleUniversityCore.Application;

public static class ApplicationExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(UsersMapper));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddScoped<ICourseSectionService, CourseSectionService>();
        services.AddScoped<IEntityBasicValidatorService, EntityBasicValidatorService>();
    }
}
