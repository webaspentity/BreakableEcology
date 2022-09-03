using System.ComponentModel.DataAnnotations;

namespace BreakableEcology.Shared.Models;

public class ProfileModel
{
    public ImageModel? Image { get; set; }
    public string? Name { get; set; }
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    public string? Telephone { get; set; }
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    public string? Email { get; set; }
    public string? Address { get; set; }
    public int? Index { get; set; }
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    public string? Password { get; set; }
}