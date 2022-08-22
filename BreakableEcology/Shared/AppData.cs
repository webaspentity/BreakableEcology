using BreakableEcology.Shared.Models;

namespace BreakableEcology.Shared;

public static class AppData
{
    public static IReadOnlyList<LinkModel> DropDownOptions { get; set; } = new List<LinkModel>()
    {
        new() {Text = "Кормушки", Url = "/"},
        new() {Text = "Готовые миксы", Url = "/"},
        new() {Text = "Отдельные виды кормов", Url = "/"},
        new() {Text = "Готовые комплекты", Url = "/"},
        new() {Text = "Аксессуары и другое", Url = "/"}
    }.AsReadOnly();

    public static IReadOnlyList<LinkModel> MenuLinks { get; set; } = new List<LinkModel>()
    {
        new() {Text = "О проекте", Url = "/"},
        new() {Text = "Птицы", Url = "/"},
        new() {Text = "Пожертвования", Url = "/"}
    }.AsReadOnly();
}
