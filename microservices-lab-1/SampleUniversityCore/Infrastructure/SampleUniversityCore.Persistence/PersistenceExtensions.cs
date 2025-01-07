using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Persistence.Repositories;

namespace SampleUniversityCore.Persistence;

public static class PersistenceExtensions
{
    public static void AddPersistence(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<SampleUniversityDbContext>(options =>
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });


        // services.AddScoped<IUnitOfWork, UnitOfWork>();
        // services.AddScoped<IClassTypeRepository, ClassTypeRepository>();
        // services.AddScoped<ICourseClassRepository, CourseClassRepository>();
        // services.AddScoped<ICourseRepository, CourseRepository>();
        // services.AddScoped<ICourseSectionRepository, CourseSectionRepository>();
        // services.AddScoped<ISectionRepository, SectionRepository>();
        // services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();
    }
}
