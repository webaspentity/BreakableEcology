using BreakableEcology.Shared.Enums;

namespace BreakableEcology.Shared.Models;

public class CardModel
{
    public bool Discount { get; set; }
    public string? Href { get; set; }
    public ImageModel? Image { get; set; }
    public LinkModel? Link { get; set; }
    public decimal? Price { get; set; }
    public int Quantity { get; set; }
    public string? Remark { get; set; }
    public bool ShowCart { get; set; }
    public bool ShowWeights { get; set; }
    public string[]? Text { get; set; }
    public ThemeType Theme { get; set; }
    public string? Title { get; set; }
}