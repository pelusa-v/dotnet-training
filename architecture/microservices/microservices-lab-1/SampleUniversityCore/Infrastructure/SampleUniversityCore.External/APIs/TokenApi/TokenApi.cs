using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;

namespace SampleUniversityCore.External.APIs;

public class TokenApi
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public TokenApi(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<string> GetTokenAsync()
    {
        var response = await _httpClient.PostAsJsonAsync("/api/auth/login", new
        {
            Email = "bati@gmail.com",  // From IConfiguration
            Password = "Batman123."
        });

        response.EnsureSuccessStatusCode();

        var tokenResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
        return tokenResponse?.Token ?? throw new Exception("Failed to retrieve token");
    }
}
