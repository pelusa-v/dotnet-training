using AutoMapper;
using use_case_1.DTOs;
using use_case_1.Etities;
using use_case_1.Integrations;

namespace use_case_1.Services;

public class PetService : IPetService
{
    private readonly IPetOwnerGateway _petOwnerGateway;
    private readonly List<Pet> MockPets;
    private readonly IMapper _mapper;

    public PetService(IPetOwnerGateway petOwnerGateway, IMapper mapper)
    {
        _mapper = mapper;
        _petOwnerGateway = petOwnerGateway;
        MockPets = new List<Pet>
        {
            new Pet { Id = 1, Name = "Garfield" },
            new Pet { Id = 2, Name = "Odie" },
            new Pet { Id = 3, Name = "Nermal" }
        };
    }
    
    public async Task<List<PetDTO>> SearchPetAsync(string name)
    {
        var petsFound = MockPets.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        var petDTOs = _mapper.Map<List<PetDTO>>(petsFound);
        foreach (var petFound in petDTOs)
        {
            var owner = await _petOwnerGateway.GetOwner(petFound.Id);
            if (owner != null)
            {
                var ownerDTO = _mapper.Map<PetOwnerDTO>(owner);
                petFound.Owner = ownerDTO;
            }
        }
        return petDTOs;
    }
}
