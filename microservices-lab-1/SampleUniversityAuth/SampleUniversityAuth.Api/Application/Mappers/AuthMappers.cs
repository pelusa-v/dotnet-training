using AutoMapper;
using SampleUniversityAuth.Api.Application.DTOs;
using SampleUniversityAuth.Api.DataAccess.Entities;

namespace SampleUniversityAuth.Api.Application.Mappers;

public class AuthMappers : Profile
{
    public AuthMappers()
    {
        CreateMap<RegisterDTO, User>();
        CreateMap<User, CreatedUserDTO>();
    }
}
