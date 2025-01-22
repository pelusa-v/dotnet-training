using use_case_1.DTOs;

namespace use_case_1.Services;

public interface IPetService
{
    Task<List<PetDTO>> SearchPetAsync(string name);
}
