using Microsoft.Extensions.DependencyInjection;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Persistence;

public static class SeedInitialData
{
    public static async Task SeedDataAsync(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<SampleUniversityDbContext>();
        
        if (!context.Courses.Any())
        {
            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Code = Guid.NewGuid(),
                    Name = "Math",
                    Description = "Mathematics",
                    Credits = 5
                },
                new Course
                {
                    Id = 2,
                    Code = Guid.NewGuid(),
                    Name = "Science",
                    Description = "Science",
                    Credits = 4
                },
                new Course
                {
                    Id = 3,
                    Code = Guid.NewGuid(),
                    Name = "English",
                    Description = "English",
                    Credits = 3
                }
            };

            await context.Courses.AddRangeAsync(courses);
            await context.SaveChangesAsync();
        }

        if (!context.Sections.Any())
        {
            var sections = new List<Section>
            {
                new Section
                {
                    Id = 1,
                    Name = "A"
                },
                new Section
                {
                    Id = 2,
                    Name = "B"
                },
                new Section
                {
                    Id = 3,
                    Name = "C"
                }
            };

            await context.Sections.AddRangeAsync(sections);
            await context.SaveChangesAsync();
        }

        if (!context.CourseSections.Any())
        {
            var courseSections = new List<CourseSection>
            {
                new CourseSection
                {
                    CourseId = 1,
                    SectionId = 1
                },
                new CourseSection
                {
                    CourseId = 1,
                    SectionId = 2
                },
                new CourseSection
                {
                    CourseId = 2,
                    SectionId = 3
                },
                new CourseSection
                {
                    CourseId = 2,
                    SectionId = 1
                },
                new CourseSection
                {
                    CourseId = 3,
                    SectionId = 1
                },
                new CourseSection
                {
                    CourseId = 3,
                    SectionId = 2
                },
                new CourseSection
                {
                    CourseId = 3,
                    SectionId = 3
                }
            };

            await context.CourseSections.AddRangeAsync(courseSections);
            await context.SaveChangesAsync();
        }

        if (!context.ClassTypes.Any())
        {
            var classTypes = new List<ClassType>
            {
                new ClassType
                {
                    Id = 1,
                    Name = "Lecture"
                },
                new ClassType
                {
                    Id = 2,
                    Name = "Lab"
                },
                new ClassType
                {
                    Id = 3,
                    Name = "Test"
                },
                new ClassType
                {
                    Id = 4,
                    Name = "Seminar"
                }
            };

            await context.ClassTypes.AddRangeAsync(classTypes);
            await context.SaveChangesAsync();
        }

        if (!context.Teachers.Any())
        {
            var teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id = 3,
                    UserId = string.Empty,
                    FullName = "Alice Doe"
                },
                new Teacher
                {
                    Id = 4,
                    UserId = string.Empty,
                    FullName = "Bob Doe"
                },
                new Teacher
                {
                    Id = 5,
                    UserId = string.Empty,
                    FullName = "Charlie Doe"
                },
                new Teacher
                {
                    Id = 6,
                    UserId = string.Empty,
                    FullName = "David Doe"
                },
                new Teacher
                {
                    Id = 7,
                    UserId = string.Empty,
                    FullName = "Eve Doe"
                }
            };

            await context.Teachers.AddRangeAsync(teachers);
            await context.SaveChangesAsync();
        }

        if (!context.CourseClasses.Any())
        {
            var courseClasses = new List<CourseClass>
            {
                new CourseClass
                {
                    CourseSectionId = 1,
                    TeacherId = 1,
                    ClassTypeId = 1,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(10, 0, 0),
                    Day = DayOfWeek.Monday
                },
                new CourseClass
                {
                    CourseSectionId = 1,
                    TeacherId = 2,
                    ClassTypeId = 2,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(12, 0, 0),
                    Day = DayOfWeek.Wednesday
                },
                new CourseClass
                {
                    CourseSectionId = 2,
                    TeacherId = 3,
                    ClassTypeId = 3,
                    StartTime = new TimeSpan(14, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0),
                    Day = DayOfWeek.Friday
                },
                new CourseClass
                {
                    CourseSectionId = 2,
                    TeacherId = 4,
                    ClassTypeId = 4,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(12, 0, 0),
                    Day = DayOfWeek.Monday
                },
                new CourseClass
                {
                    CourseSectionId = 3,
                    TeacherId = 5,
                    ClassTypeId = 1,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(10, 0, 0),
                    Day = DayOfWeek.Wednesday
                },
                new CourseClass
                {
                    CourseSectionId = 3,
                    TeacherId = 6,
                    ClassTypeId = 2,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(12, 0, 0),
                    Day = DayOfWeek.Friday
                },
                new CourseClass
                {
                    CourseSectionId = 4,
                    TeacherId = 7,
                    ClassTypeId = 3,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(10, 0, 0),
                    Day = DayOfWeek.Monday
                },
                new CourseClass
                {
                    CourseSectionId = 4,
                    TeacherId = 1,
                    ClassTypeId = 4,
                    StartTime = new TimeSpan(12, 0, 0),
                    EndTime = new TimeSpan(15, 0, 0),
                    Day = DayOfWeek.Wednesday
                },
                new CourseClass
                {
                    CourseSectionId = 5,
                    TeacherId = 2,
                    ClassTypeId = 1,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(10, 0, 0),
                    Day = DayOfWeek.Thursday
                },
            };

            await context.CourseClasses.AddRangeAsync(courseClasses);
            await context.SaveChangesAsync();
        }

        if (!context.Students.Any())
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    UserId = string.Empty,
                    FullName = "Alice Doe"
                },
                new Student
                {
                    Id = 2,
                    UserId = string.Empty,
                    FullName = "Bob Doe"
                },
                new Student
                {
                    Id = 3,
                    UserId = string.Empty,
                    FullName = "Charlie Doe"
                },
                new Student
                {
                    Id = 4,
                    UserId = string.Empty,
                    FullName = "David Doe"
                },
                new Student
                {
                    Id = 5,
                    UserId = string.Empty,
                    FullName = "Eve Doe"
                }
            };

            await context.Students.AddRangeAsync(students);
            await context.SaveChangesAsync();
        }
    }
}
