using System.Text.Json.Serialization;

namespace use_case_1.Integrations.Response;

public class PetOwnerRes
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
