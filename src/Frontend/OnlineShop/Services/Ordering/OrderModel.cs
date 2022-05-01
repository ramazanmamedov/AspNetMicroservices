namespace OnlineShop.Services.Ordering;

public class OrderModel
{
    public List<OrderItem>? Items { get; set; }
}

public class OrderItem
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public decimal TotalPrice { get; set; }
}