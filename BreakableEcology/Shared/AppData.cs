using BreakableEcology.Shared.Models;
using System.Linq.Expressions;

namespace BreakableEcology.Shared;

public static class AppData
{
    public static List<LinkModel> DropDownOptions { get; set; } = new List<LinkModel>()
    {
        new() {Text = "Кормушки", Url = "/"},
        new() {Text = "Готовые миксы", Url = "/"},
        new() {Text = "Отдельные виды кормов", Url = "/"},
        new() {Text = "Готовые комплекты", Url = "/"},
        new() {Text = "Аксессуары и другое", Url = "/"}
    };

    public static List<LinkModel> MenuLinks { get; set; } = new List<LinkModel>()
    {
        new() {Text = "О проекте", Url = "/"},
        new() {Text = "Птицы", Url = "/"},
        new() {Text = "Пожертвования", Url = "/"}
    };

    public static List<CatalogCardModel> CatalogCards { get; set; } = new List<CatalogCardModel>()
    {
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Кормушки"}, CatalogName = "Кормушки", Remark = null, Link = new(){ Text = "Подробнее", Url = "/"}},
        new() { Image = new(){Source = "images/catalog/mixes.jpg", Alt = "Готовые миксы"}, CatalogName = "Готовые миксы", Remark = "(смеси кормов)", Link = new(){ Text = "Подробнее", Url = "/"}},
        new() { Image = new(){Source = "images/catalog/individual_feeds.jpg", Alt = "Отдельные виды кормов"}, CatalogName = "Отдельные виды кормов", Remark = "(зерен)", Link = new(){ Text = "Подробнее", Url = "/"}},
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Комплекты"}, CatalogName = "Готовые комплекты", Remark = null, Link = new(){ Text = "Подробнее", Url = "/"}},
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Аксессуары"}, CatalogName = "Аксессуары и другое", Remark = null, Link = new(){ Text = "Подробнее", Url = "/"}}
    };

    public static List<int> Weights { get; set; } = new List<int>()
    {
        200, 400, 800, 1
    };
}
