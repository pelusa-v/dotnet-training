using System.Text.Json;
using System.Text.Json.Serialization;
using use_case_1.Integrations.Response;

namespace use_case_1.Integrations;

public class PetOwnerGateway : IPetOwnerGateway
{
    private readonly HttpClient _httpClient;
    
    public PetOwnerGateway(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PetOwnerRes?> GetOwner(int petId)
    {
        var httpRes = await _httpClient.GetAsync($"/api/pets/{petId}/owner");
        var resStr = await httpRes.Content.ReadAsStringAsync();
        var res = JsonSerializer.Deserialize<PetOwnerRes>(resStr);
        return res;
    }
}
