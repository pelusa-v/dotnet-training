using use_case_1.Integrations.Response;

namespace use_case_1.Integrations;

public interface IPetOwnerGateway
{
    Task<PetOwnerRes?> GetOwner(int petId);
}
