using Identity.Common;

namespace OnlineShop.Services.Identity;

public class AuthorizeApi : IAuthorizeApi
{
    private readonly HttpClient _httpClient;
    private const string IdentityHost = "https://localhost:7244/api/v1"; 

    public AuthorizeApi(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task Login(LoginParameters loginParameters)
    {
        var result = await _httpClient.PostAsJsonAsync($"{IdentityHost}/Authorize/Login", loginParameters);
        if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
        result.EnsureSuccessStatusCode();
    }

    public async Task Logout()
    {
        var result = await _httpClient.PostAsync($"{IdentityHost}/Authorize/Logout", null);
        result.EnsureSuccessStatusCode();
    }

    public async Task Register(RegisterParameters registerParameters)
    {
        var result = await _httpClient.PostAsJsonAsync($"{IdentityHost}/Authorize/Register", registerParameters);
        if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
        result.EnsureSuccessStatusCode();
    }

    public async Task<UserInfo> GetUserInfo()
    {
        var result = await _httpClient.GetFromJsonAsync<UserInfo>($"{IdentityHost}/Authorize/UserInfo");
        return result;
    }
}