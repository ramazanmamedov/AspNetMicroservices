using Identity.Common;

namespace OnlineShop.Services.Identity;

public class AuthorizeApi : IAuthorizeApi
{
    private readonly HttpClient _httpClient;

    public AuthorizeApi(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient("Auth");
    }

    public async Task Login(LoginParameters loginParameters)
    {
        var result = await _httpClient.PostAsJsonAsync("Authorize/Login", loginParameters);
        if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
        result.EnsureSuccessStatusCode();
    }

    public async Task Logout()
    {
        var result = await _httpClient.PostAsync("Authorize/Logout", null);
        result.EnsureSuccessStatusCode();
    }

    public async Task Register(RegisterParameters registerParameters)
    {
        var result = await _httpClient.PostAsJsonAsync("Authorize/Register", registerParameters);
        if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
        result.EnsureSuccessStatusCode();
    }

    public async Task<UserInfo> GetUserInfo()
    {
        var result = await _httpClient.GetFromJsonAsync<UserInfo>("Authorize/UserInfo");
        return result;
    }
}