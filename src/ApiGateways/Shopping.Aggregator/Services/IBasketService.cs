using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services;

public interface IBasketService
{
    Task<BasketModel> GetBasketAsync(string userName);
}