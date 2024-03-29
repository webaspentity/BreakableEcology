﻿using BreakableEcology.Shared.Models;

namespace BreakableEcology.Shared;

public static class AppData
{
    public static CartModel Cart { get; set; } = new() { Products = new() { } };

    public static List<LinkModel> DropDownOptions { get; set; } = new()
    {
        new() {Text = "Кормушки", Url = "/catalog/feeders"},
        new() {Text = "Готовые миксы", Url = "/catalog/mixes"},
        new() {Text = "Отдельные виды кормов", Url = "/catalog/grains"},
        new() {Text = "Готовые комплекты", Url = "/catalog/kits"},
        new() {Text = "Аксессуары и другое", Url = "/catalog/accessories"}
    };

    public static List<LinkModel> MenuLinks { get; set; } = new()
    {
        new() {Text = "О проекте", Url = "/about"},
        new() {Text = "Птицы", Url = "/birds"},
        new() {Text = "Пожертвования", Url = "/donations"}
    };

    public static List<CardModel> CatalogCards { get; set; } = new()
    {
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Кормушки"}, Title = "Кормушки", Remark = null, Link = new(){ Text = "Подробнее", Url = "/catalog/feeders"}, Href = "/catalog/feeders", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/mixes.jpg", Alt = "Готовые миксы"}, Title = "Готовые миксы", Remark = "(смеси кормов)", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes"}, Href = "/catalog/mixes", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/individual_feeds.jpg", Alt = "Отдельные виды кормов"}, Title = "Отдельные виды кормов", Remark = "(зерен)", Link = new(){ Text = "Подробнее", Url = "/catalog/grains"}, Theme = Enums.ThemeType.Light, Href = "/catalog/grains"}
    };

    public static List<CardModel> MixesCards { get; set; } = new()
    {
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}, ShowWeights = true, Href = "/catalog/mixes/mix", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}, ShowWeights = true, Href = "/catalog/mixes/mix", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}, ShowWeights = true, Href = "/catalog/mixes/mix", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/mixes/ovomix.jpg", Alt = "Готовые миксы"}, Title = "PADOVAN OVOMIX GOLD ROSSO", Remark = "Корм для птиц", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}, ShowWeights = true, Href = "/catalog/mixes/mix", ShowCart = true, Theme = Enums.ThemeType.Grey}
    };

    public static List<CardModel> BirdSpeciesCards { get; set; } = new()
    {
        new() { Image = new(){Source = "images/birds/sparrow.jpg", Alt = "Домовый воробей"}, Title = "Домовый воробей", Remark = "(воробьи)", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/bird"}, Href = "/catalog/mixes/bird", Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/birds/sparrow.jpg", Alt = "Домовый воробей"}, Title = "Домовый воробей", Remark = "(воробьи)", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/bird"}, Href = "/catalog/mixes/bird", Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/birds/sparrow.jpg", Alt = "Домовый воробей"}, Title = "Домовый воробей", Remark = "(воробьи)", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/bird"}, Href = "/catalog/mixes/bird", Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/birds/sparrow.jpg", Alt = "Домовый воробей"}, Title = "Домовый воробей", Remark = "(воробьи)", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/bird"}, Href = "/catalog/mixes/bird", Theme = Enums.ThemeType.Grey}
    };

    public static List<CardModel> GrainsCards { get; set; } = new()
    {
        new() { Image = new(){Source = "images/grains/rio.jpg", Alt = "Зёрна"}, Title = "Корм для птиц RIO Линька", Remark = "для волнистых попугайчиков", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient"}, ShowWeights = true, Href = "/catalog/mixes/ingredient", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/grains/rio.jpg", Alt = "Зёрна"}, Title = "Корм для птиц RIO Линька", Remark = "для волнистых попугайчиков", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient"}, ShowWeights = true, Href = "/catalog/mixes/ingredient", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/grains/rio.jpg", Alt = "Зёрна"}, Title = "Корм для птиц RIO Линька", Remark = "для волнистых попугайчиков", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient"}, ShowWeights = true, Href = "/catalog/mixes/ingredient", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/grains/rio.jpg", Alt = "Зёрна"}, Title = "Корм для птиц RIO Линька", Remark = "для волнистых попугайчиков", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient"}, ShowWeights = true, Href = "/catalog/mixes/ingredient", ShowCart = true, Theme = Enums.ThemeType.Grey, Discount = true}
    };

    public static List<CardModel> FeedersCards { get; set; } = new()
    {
        new() { Image = new(){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Title = "Комплект-агро \"Избушка на курьих ножках\"", Remark = "кормушка малая", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, Href = "/feeders", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Title = "Комплект-агро \"Избушка на курьих ножках\"", Remark = "кормушка малая", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, Href = "/feeders", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Title = "Комплект-агро \"Избушка на курьих ножках\"", Remark = "кормушка малая", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, Href = "/feeders", ShowCart = true, Theme = Enums.ThemeType.Grey},
        new() { Image = new(){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Title = "Комплект-агро \"Избушка на курьих ножках\"", Remark = "кормушка малая", Price = 1000, Link = new(){ Text = "Подробнее", Url = "/"}, Href = "/feeders", ShowCart = true, Theme = Enums.ThemeType.Grey}
    };

    public static List<CardModel> Catalog { get; set; } = new()
    {
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Кормушки"}, Title = "Кормушки", Remark = null, Link = new(){ Text = "Подробнее", Url = "/catalog/feeders"}, Href = "/catalog/feeders", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/mixes.jpg", Alt = "Готовые миксы"}, Title = "Готовые миксы", Remark = "(смеси кормов)", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes"}, Href = "/catalog/mixes", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/individual_feeds.jpg", Alt = "Отдельные виды кормов"}, Title = "Отдельные виды кормов", Remark = "(зерен)", Link = new(){ Text = "Подробнее", Url = "/catalog/grains"}, Theme = Enums.ThemeType.Light, Href = "/catalog/grains"},
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Комплекты"}, Title = "Готовые комплекты", Remark = null, Link = new(){ Text = "Подробнее", Url = "/catalog/kits"}, Href = "/catalog/kits", Theme = Enums.ThemeType.Light},
        new() { Image = new(){Source = "images/catalog/feeders.jpg", Alt = "Аксессуары"}, Title = "Аксессуары и другое", Remark = null, Link = new(){ Text = "Подробнее", Url = "/catalog/accessories"}, Href = "/catalog/accessories", Theme = Enums.ThemeType.Light}
    };

    public static List<CardModel> FeedersList { get; set; } = new() {
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new (){Source = "images/feeders/feeder.jpg", Alt = "Кормушка"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Кормушка малая", Title = "Комплект-агро \"Избушка на курьих ножках\"", Theme = Enums.ThemeType.Grey, ShowCart = true }
    };

    public static List<CardModel> MixesList { get; set; } = new()
    {
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/mixes/ovomix.jpg", Alt = "Готовый микс"}, Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Корм для птиц", Title = "PADOVAN OVOMIX GOLD ROSSO", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true }
    };

    public static List<CardModel> GrainsList { get; set; } = new()
    {
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new (){Source = "images/grains/rio.jpg", Alt = "Корм для птиц"}, Href = "/catalog/mixes/ingredient", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/ingredient" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true }
    };

    public static List<CardModel> KitsList { get; set; } = new()
    {
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true },
        new() { Image = new() { Source = "images/catalog/ready_made_kits/rio.jpg", Alt = "Корм для птиц" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "для волнистых попугайчиков", Title = "Корм для птиц RIO Линька", Theme = Enums.ThemeType.Grey, ShowCart = true, ShowWeights = true }
    };

    public static List<CardModel> AccessoriesList { get; set; } = new()
    {
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 1000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 2000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 3000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true },
        new() { Image = new() { Source = "images/catalog/accessories/triol.jpg", Alt = "Аксессуар" }, Href = "/catalog/mixes/mix", Link = new() { Text = "Подробнее", Url = "/catalog/mixes/mix" }, Price = 4000, Remark = "Домик для птиц", Title = "Домик для птиц TRIOL из кокоса", Theme = Enums.ThemeType.Grey, ShowCart = true }
    };

    public static List<SlideModel> BirdsSlides { get; set; } = new()
    {
        new(){ Image = new(){ Source ="images/birds_slides/pigeon.png", Alt = "Голубь"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Голубь"},
        new(){ Image = new(){ Source ="images/birds_slides/sparrow.png", Alt = "Воробей"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Воробей"},
        new(){ Image = new(){ Source ="images/birds_slides/starling.png", Alt = "Ласточка"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Ласточка"},
        new(){ Image = new(){ Source ="images/birds_slides/swallow.png", Alt = "Скворец"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Скворец"},
        new(){ Image = new(){ Source ="images/birds_slides/pigeon.png", Alt = "Голубь"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Голубь 2"},
        new(){ Image = new(){ Source ="images/birds_slides/sparrow.png", Alt = "Воробей"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Воробей 2"},
        new(){ Image = new(){ Source ="images/birds_slides/starling.png", Alt = "Ласточка"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Ласточка 2"},
        new(){ Image = new(){ Source ="images/birds_slides/swallow.png", Alt = "Скворец"}, Link = new(){ Url ="/catalog/mixes/bird", Text = null}, Title = "Скворец 2"}
    };

    public static List<SlideModel> GrainsSlides { get; set; } = new()
    {
        new(){ Image = new(){ Source ="images/grains_slides/millet.png", Alt = "Пшено"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Пшено"},
        new(){ Image = new(){ Source ="images/grains_slides/switchgrass.png", Alt = "Просо"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Просо"},
        new(){ Image = new(){ Source ="images/grains_slides/flax.png", Alt = "Лён"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Лён"},
        new(){ Image = new(){ Source ="images/grains_slides/wheat.png", Alt = "Пшеница"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Пшеница"},
        new(){ Image = new(){ Source ="images/grains_slides/millet.png", Alt = "Пшено"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Пшено 2"},
        new(){ Image = new(){ Source ="images/grains_slides/switchgrass.png", Alt = "Просо"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Просо 2"},
        new(){ Image = new(){ Source ="images/grains_slides/flax.png", Alt = "Лён"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Лён 2"},
        new(){ Image = new(){ Source ="images/grains_slides/wheat.png", Alt = "Пшеница"}, Link = new(){ Url ="/catalog/mixes/ingredient", Text = null}, Title = "Пшеница 2"}
    };

    public static List<SlideModel> MixesSlides { get; set; } = new()
    {
        new(){ Image = new(){ Source ="images/mixes_slides/cliffi.png", Alt = "Cliffi (Италия)"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Cliffi (Италия)"},
        new(){ Image = new(){ Source ="images/mixes_slides/benelux.png", Alt = "Benelux корма"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Benelux корма"},
        new(){ Image = new(){ Source ="images/mixes_slides/cliffi_2.png", Alt = "Cliffi (Италия)"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Cliffi (Италия)"},
        new(){ Image = new(){ Source ="images/mixes_slides/benelux_2.png", Alt = "Benelux корма"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Benelux корма"},
        new(){ Image = new(){ Source ="images/mixes_slides/cliffi.png", Alt = "Cliffi (Италия)"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Cliffi (Италия) 2"},
        new(){ Image = new(){ Source ="images/mixes_slides/benelux.png", Alt = "Benelux корма"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Benelux корма 2"},
        new(){ Image = new(){ Source ="images/mixes_slides/cliffi_2.png", Alt = "Cliffi (Италия)"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Cliffi (Италия) 2"},
        new(){ Image = new(){ Source ="images/mixes_slides/benelux_2.png", Alt = "Benelux корма"}, Link = new(){ Url ="/catalog/mixes/mix", Text = null}, Title = "Benelux корма 2"}
    };

    public static CardModel ProductDetails { get; set; } = new()
    {
        Image = new() { Source = "images/details/ovomix.jpg", Alt = "Готовый микс" },
        Href = "/catalog/mixes/mix",
        Link = null,
        Price = 1000,
        Remark = null,
        Title = "PADOVAN OVOMIX GOLD ROSSO",
        Theme = Enums.ThemeType.Grey,
        ShowCart = false,
        ShowWeights = true
    };

    public static List<CardModel> ProductTheyLook = new() {
        new () { Price = 1000, Image = new(){ Source = "images/products_they_look/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}},
        new () { Price = 1000, Image = new(){ Source = "images/products_they_look/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}},
        new () { Price = 1000, Image = new(){ Source = "images/products_they_look/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}},
        new () { Price = 1000, Image = new(){ Source = "images/products_they_look/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}, Discount = true}
    };

    public static List<CardModel> ProductTheyBuy = new() {
        new () { Price = 1000, Image = new(){ Source = "images/products_they_buy/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}},
        new () { Price = 1000, Image = new(){ Source = "images/products_they_buy/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}},
        new () { Price = 1000, Image = new(){ Source = "images/products_they_buy/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}},
        new () { Price = 1000, Image = new(){ Source = "images/products_they_buy/rio.jpg", Alt = "Корм RIO"}, Theme = Enums.ThemeType.Grey, ShowWeights = true,Remark = "для волнистых попугайчиков", ShowCart = true, Title = "Корм для птиц RIO Линька", Href = "/catalog/mixes/mix", Link = new(){ Text = "Подробнее", Url = "/catalog/mixes/mix"}, Discount = true}
    };

    public static CardModel BirdDetails { get; set; } = new()
    {
        Image = new() { Source = "images/details/sparrow.jpg", Alt = "Домовый воробей" },
        Href = "/catalog/mixes/bird",
        Link = null,
        Remark = null,
        Title = "Домовый воробей",
        Theme = Enums.ThemeType.Grey,
        ShowCart = false,
        ShowWeights = true,
        Text = new[] {
            "Воробей – это птица, знакомая всем, как взрослым, так и детям. Это небольшая птица, которая, на первый взгляд, имеет монотонный серо-коричневый окрас оперения, но, если внимательно присмотреться, то можно обнаружить более контрастные тона, больше темные или даже черные. Область головы, брюшка и область ушей раскрашены в светлые оттенки, причем их интенсивность варьируется от, светло-серых до светло-коричневых тонов.",
            "У воробья мощный клюв темного оттенка, а хвост короткий и окрашен в одни тона. Вырастают воробьи до 15 сантиметров максимум, при весе не больше 35 граммов. Размах крыльев птицы достигает около 27 сантиметров."
        }
    };

    public static CardModel GrainDetails { get; set; } = new()
    {
        Image = new() { Source = "images/details/grain.jpg", Alt = "Пшеница" },
        Href = "/catalog/mixes/ingredient",
        Link = null,
        Remark = null,
        Title = "Пшеница",
        Theme = Enums.ThemeType.Grey,
        ShowCart = false,
        ShowWeights = false,
        Text = new[] {
            "Пшеница представляет собой однолетнее растение, способное вырастать до полутораметровой высоты. Заросли при этом всегда прямые и плотные, поскольку стебель растения практически идеально прямой и не имеет ответвлений. Однако, от стебля отходят тонкие, неширокие (до двух сантиметров) и длинные листья, благодаря чему заросли этого растения выглядят очень густыми. На вершине стебля располагается колосок, в котором находятся зёрна.",
            "Пшеница окрашена в зелёный цвет, но постепенно меняет его на золотистый.В момент сбора урожая пшеничные поля сплошь окрашены в золотистый цвет.",
            "Зерна пшеницы, находящиеся в колоске, защищены чешуйками и волосками. Благодаря чему не осыпаются на землю. Но спелые зёрна легко покидают своё укрытие, стоит лишь хорошенько ударить по колоску. На этом принципе и основываются методы сбора данного вида урожая."
        }
    };

    public static List<CartProductModel> Orders { get; set; } = new()
    {
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 5, Total = 228, Sent = true
        },
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 5, Total = 228, Sent = false
        },
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 5, Total = 228, Sent = false
        },
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 5, Total = 228, Sent = false
        }
    };

    public static List<CartProductModel> CartProducts { get; set; } = new()
    {
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 1, Total = 228, Sent = false, Price = 228
        },
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 1, Total = 228, Sent = false, Price = 228
        },
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 1, Total = 228, Sent = false, Price = 228
        },
        new(){
            Article = "Т00001632",
            Image = new(){Source = "images/fiory_feed.jpg", Alt = "Товар"},
            Name = "Корм для птиц FIORY Смесь для попугаев  400г",
            Quantity = 1, Total = 228, Sent = false, Price = 228
        }
    };
}