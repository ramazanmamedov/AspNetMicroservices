namespace OnlineShop.Application.Basket;

public class ShoppingCart
{
    public string UserName { get; set; }
    public decimal Total { get; set; }
    public List<ShoppingCartItem> Items { get; set; } = new();
}