namespace OnlineShop.Services.Basket;

public class ShoppingCart
{
    public string UserName { get; set; }
    public decimal TotalPrice { get; set; }
    public List<ShoppingCartItem>? Items { get; set; } = new();
}