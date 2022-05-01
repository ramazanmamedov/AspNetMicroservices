using System.Text;
using System.Text.Json;

namespace OnlineShop.Services.Basket;

public class BasketService
{
    private readonly IHttpClientFactory _clientFactory;

    public BasketService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<ShoppingCart?> UpdateBasketAsync(ShoppingCart cart)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, new Uri("http://localhost:8010/Basket"));
        request.Headers.Add("Accept", "application/json; charset=utf-8");
        var json = JsonSerializer.Serialize(cart);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");
        
        var httpClient = _clientFactory.CreateClient();
        var response = await httpClient.SendAsync(request);
        
        if (!response.IsSuccessStatusCode) return new ShoppingCart();
        
        var result = await response.Content.ReadFromJsonAsync<ShoppingCart>();
        return result;

    }

    public async Task<ShoppingCart?> GetBasketAsync(string userName)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, new Uri($"http://localhost:8010/Basket/{userName}"));
        request.Headers.Add("Accept", "application/json; charset=utf-8");

        var httpClient = _clientFactory.CreateClient();
        var response = await httpClient.SendAsync(request);
        
        if (!response.IsSuccessStatusCode) return new ShoppingCart();
        
        var result = await response.Content.ReadFromJsonAsync<ShoppingCart>();
        return result;
    }
}