using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Persistance
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext context, ILogger<OrderContextSeed> logger)
        {
            if (!context.Orders.Any())
            {
                await context.Orders.AddRangeAsync(GetPreconfiguredOrders());
                await context.SaveChangesAsync();
                logger.LogInformation("Seed database charged with context {DbContext}", nameof(OrderContext));
            }
        }
        
        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new() {UserName = "rmz",  TotalPrice = 6000 }
            };
        }
    }
    
    
}