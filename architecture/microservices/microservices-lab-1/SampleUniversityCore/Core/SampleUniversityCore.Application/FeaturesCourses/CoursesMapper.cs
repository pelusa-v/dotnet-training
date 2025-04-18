using AutoMapper;
using SampleUniversityCore.Application.FeaturesUsers.AddTeacher;
using SampleUniversityCore.Application.Services.DTOs;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application.FeaturesCourses;

public class CoursesMapper : Profile
{
    public CoursesMapper()
    {
        CreateMap<CourseSection, CourseSectionDetailDTO>();
        CreateMap<Course, CourseDTO>();
        CreateMap<Section, SectionDTO>();
        CreateMap<CourseClass, CourseClassDTO>();
        CreateMap<ClassType, ClassTypeDTO>();
        CreateMap<Teacher, TeacherDTO>();
    }
}
