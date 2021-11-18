using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services;

public interface IOrderService
{
    Task<IEnumerable<OrderResponseModel>> GetOrdersByUserNameAsync(string userName);
}