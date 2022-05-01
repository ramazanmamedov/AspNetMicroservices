namespace OnlineShop.Services.Ordering;

public class OrderService
{
    private readonly HttpClient _httpClient;

    public OrderService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient("Ocelot");
    }

    public async Task<List<OrderItem>> GetOrdersAsync(string email)
    {
        var response = await _httpClient.GetAsync($"Order/{email}");
        if (!response.IsSuccessStatusCode) return new List<OrderItem>();
        
        var result = await response.Content.ReadFromJsonAsync<List<OrderItem>>();
        return result;
    }
}