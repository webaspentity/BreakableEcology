namespace BreakableEcology.Shared.Models;

public class CartProductModel
{
    public ImageModel? Image { get; set; }
    public string? Name { get; set; }
    public string? Article { get; set; }
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public bool Sent { get; set; }
    public decimal Price { get; set; }
}