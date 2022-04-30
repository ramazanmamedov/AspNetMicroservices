namespace OnlineShop.Application.Basket;

public class BasketService
{
    private ShoppingCart? _cart;
    public async Task AddToBasketAsync(ShoppingCartItem item)
    {
        if (_cart == null)
        {
            _cart = new ShoppingCart();
        }
        _cart.Items.Add(item);
    }

    public ShoppingCart GetBasket()
    {
        return _cart!;
    }
}