using System.Net.Http.Headers;

namespace SampleUniversityCore.External.APIs;

public class AuthHandler : DelegatingHandler
{
    private readonly TokenApi _tokenApi;

    public AuthHandler(TokenApi tokenApi)
    {
        _tokenApi = tokenApi;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _tokenApi.GetTokenAsync();
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        return await base.SendAsync(request, cancellationToken);
    }
}
