namespace BreakableEcology.Shared.Models;

using System.ComponentModel.DataAnnotations;

public class UserModel
{
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    public string? Telephone { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    public string? Password { get; set; }
}