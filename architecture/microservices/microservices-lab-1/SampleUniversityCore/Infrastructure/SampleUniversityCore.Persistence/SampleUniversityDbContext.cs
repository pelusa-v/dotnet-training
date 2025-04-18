using Microsoft.EntityFrameworkCore;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Persistence;

public class SampleUniversityDbContext : DbContext
{
    public SampleUniversityDbContext(DbContextOptions<SampleUniversityDbContext> options) : base(options)
    {
    }

    public DbSet<ClassType> ClassTypes { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseClass> CourseClasses { get; set; }
    public DbSet<CourseSection> CourseSections { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
