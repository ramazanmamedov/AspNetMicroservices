namespace OnlineShop.Services.Catalog;

public class CatalogService
{
    private readonly HttpClient _httpClient;

    public CatalogService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient("Ocelot");
    }

    public async Task<CatalogModel?> GetCatalogAsync()
    {
        var response = await _httpClient.GetAsync("Catalog");
        if (!response.IsSuccessStatusCode) return new CatalogModel();
        var products = await response.Content.ReadFromJsonAsync<Product[]>();
        return new CatalogModel {Products = products};
    }
}