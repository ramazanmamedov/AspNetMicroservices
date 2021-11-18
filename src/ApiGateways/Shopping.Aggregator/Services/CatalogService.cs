using Shopping.Aggregator.Extensions;
using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services;

public class CatalogService : ICatalogService
{
    private readonly HttpClient _client;

    public CatalogService(HttpClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public async Task<IEnumerable<CatalogModel>> GetCatalogAsync()
    {
        var response = await _client.GetAsync("api/v1/Catalog");
        return await response.ReadContentAs<List<CatalogModel>>();
    }

    public async Task<IEnumerable<CatalogModel>> GetCatalogByCategoryAsync(string category)
    {
        var response = await _client.GetAsync($"api/v1/Catalog/GetProductsByCategory/{category}");
        return await response.ReadContentAs<List<CatalogModel>>();
    }

    public async Task<CatalogModel> GetCatalogAsync(string id)
    {
        var response = await _client.GetAsync($"api/v1/Catalog/{id}");
        return await response.ReadContentAs<CatalogModel>();
    }
}