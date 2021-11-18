using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services;

public interface ICatalogService
{
    Task<IEnumerable<CatalogModel>> GetCatalogAsync();
    Task<IEnumerable<CatalogModel>> GetCatalogByCategoryAsync(string category);
    Task<CatalogModel> GetCatalogAsync(string id);
}