namespace OnlineShop.Services.Basket;

public class BasketService
{
    private readonly HttpClient _httpClient;

    public BasketService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient("Ocelot");
    }

    public async Task<ShoppingCart?> UpdateBasketAsync(ShoppingCart cart)
    {
        var response = await _httpClient.PostAsJsonAsync("Basket", cart);
        if (!response.IsSuccessStatusCode) return new ShoppingCart();
        
        var result = await response.Content.ReadFromJsonAsync<ShoppingCart>();
        return result;

    }

    public async Task<ShoppingCart?> GetBasketAsync(string userName)
    {
        var response = await _httpClient.GetAsync($"Basket/{userName}");
        if (!response.IsSuccessStatusCode) return new ShoppingCart();
        
        var result = await response.Content.ReadFromJsonAsync<ShoppingCart>();
        return result;
    }

    public async Task<bool> CheckoutOrderAsync(BasketCheckoutOrder order)
    {
        var response = await _httpClient.PostAsJsonAsync("Basket/Checkout", order);
        return response.IsSuccessStatusCode;
    }
}