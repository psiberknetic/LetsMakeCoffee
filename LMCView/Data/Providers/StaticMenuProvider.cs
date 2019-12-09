using LMC.Common;
using LMC.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LMC.Data.Providers
{
    public class StaticMenuProvider : IMenuProvider
    {
        readonly IEnumerable<MenuItem> _menu = new[]{
            new MenuItem(){
                Id = Guid.Parse("8c5598e0-2a3e-4828-961a-ae9aaf20ca7b"),
                Name = "20 oz. Coffee",
                Category = MenuCategory.CoffeeDrink,
                Description = "A fine dark roast coffee",
                Price = 0.99m
            },
            new MenuItem(){
                Id = Guid.Parse("4e8a6dea-78cf-4ef3-895d-ea255334f00a"),
                Name = "32 oz. Coffee",
                Category = MenuCategory.CoffeeDrink,
                Description = "A fine dark roast coffee",
                Price = 1.39m
            },
            new MenuItem(){
                Id = Guid.Parse("faa8c851-4186-4662-84e6-b31ca8bedc1f"),
                Name = "20 oz. Mochachino",
                Category = MenuCategory.CoffeeDrink,
                Description = "A blend of coffee, chocolate and milk. Perfect for choco-holics, or people who need a not too indulgent chocolate fix.",
                Price = 2.49m
            },
            new MenuItem(){
                Id = Guid.Parse("965acbf6-02fc-456b-ad8e-c64527d65c53"),
                Name = "20 oz. Chai Latte",
                Category = MenuCategory.NonCoffeeDrink,
                Description = "Spicy, delicious Chai tea blended with milk.",
                Price = 2.49m
            },
            new MenuItem(){
                Id = Guid.Parse("74f32f50-b29b-4bee-a129-c74938ef2596"),
                Name = "Chocolate Croissant",
                Category = MenuCategory.Pastry,
                Description = "A buttery, flaky croissant filled with delicious dark chocolate",
                Price = 3.99m
            },
        };

        public MenuItem GetMenuItem(Guid id)
        {
            return _menu.FirstOrDefault(mi => mi.Id == id);
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _menu;
        }

        public IEnumerable<MenuItem> GetMenuItemsByCategory(MenuCategory category)
        {
            return _menu.Where(mi => mi.Category == category);
        }
    }
}
