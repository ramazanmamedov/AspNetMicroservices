using System.Text.Json;

namespace OnlineShop.Application.Catalog;

public class CatalogService
{
    private readonly IHttpClientFactory _clientFactory;

    public CatalogService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<CatalogModel?> GetCatalogAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, new Uri("http://localhost:8010/Catalog"));
        request.Headers.Add("Accept", "application/json; charset=utf-8");

        var httpClient = _clientFactory.CreateClient();
        var response = await httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode) return new CatalogModel();
        
        var products = await response.Content.ReadFromJsonAsync<Product[]>();
        return new CatalogModel {Products = products};
    }
}