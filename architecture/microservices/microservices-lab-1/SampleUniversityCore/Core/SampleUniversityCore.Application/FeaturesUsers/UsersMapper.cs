using AutoMapper;
using SampleUniversityCore.Application.ExternalServices;
using SampleUniversityCore.Application.FeaturesUsers.AddTeacher;
using SampleUniversityCore.Domain.Entities;

namespace SampleUniversityCore.Application;

public class UsersMapper : Profile
{
    public UsersMapper()
    {
        CreateMap<AddTeacherCommand, Teacher>();
        CreateMap<AddTeacherCommand, CreateUserDTO>();
        CreateMap<Teacher, TeacherDTO>();
    }
}
