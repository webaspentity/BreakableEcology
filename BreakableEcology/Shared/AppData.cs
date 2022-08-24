﻿using BreakableEcology.Shared.Models;

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

    public static List<CardModel> CatalogCards { get; set; } = new List<CardModel>()
    {
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Кормушки"}, Title = "Кормушки", Remark = null, Link = new(){ Text = "Подробнее", Url = "/"}, Href = "/feeders", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/mixes.jpg", Alt = "Готовые миксы"}, Title = "Готовые миксы", Remark = "(смеси кормов)", Link = new(){ Text = "Подробнее", Url = "/"}, Href = "/mixes", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/individual_feeds.jpg", Alt = "Отдельные виды кормов"}, Title = "Отдельные виды кормов", Remark = "(зерен)", Link = new(){ Text = "Подробнее", Url = "/"}, Theme = Enums.ThemeType.Light, Href = "/"}
    };

    public static List<CardModel> MixesCards { get; set; } = new List<CardModel>()
    {
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, ShowWeights = true, Href = "/mixes", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, ShowWeights = true, Href = "/mixes", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, ShowWeights = true, Href = "/mixes", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, ShowWeights = true, Href = "/mixes", ShowCart = true, Theme = Enums.ThemeType.Grey}
    };
}
