using AutoMapper;
using SampleUniversityCore.Application.UsersFeatures.AddTeacher;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application;

public class UsersMapper : Profile
{
    public UsersMapper()
    {
        CreateMap<AddTeacherCommand, Teacher>();
        CreateMap<Teacher, AddTeacherDTO>();
    }
}
