using AutoMapper;
using use_case_1.DTOs;
using use_case_1.Etities;
using use_case_1.Integrations.Response;

namespace use_case_1;

public class PetProfile : Profile
{
    public PetProfile()
    {
        CreateMap<Pet, PetDTO>();
        CreateMap<PetOwnerRes, PetOwnerDTO>();
    }
}
