namespace BreakableEcology.Shared.Models;

public class CartModel
{
    public List<CardModel>? Products { get; set; }

    public void AddToCart(CardModel product)
    {
        Products.Add(product);
    }
}