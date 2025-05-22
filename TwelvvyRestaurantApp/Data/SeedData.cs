using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelvvyRestaurantApp.Data
{
    class SeedData
    {
        public static List<MenuCategory> GetMenuCategories()
        {
            return new List<MenuCategory>
            {
              new MenuCategory { Id = 1, Name = "Beverages", Icon = "drinks.png" },
              new MenuCategory { Id = 2, Name = "Fast Food", Icon = "fastfood.png" },
              new MenuCategory { Id = 3, Name = "Snacks", Icon = "snack.png" },
              new MenuCategory { Id = 4, Name = "Desserts", Icon = "cake.png" },
            
            };
        }
        public static List<MenuItem> GetMenuItems() { 
           return new List<MenuItem>
           {
           //new MenuItem { Id = 1, Name = "Black Label beer", Icon = "black.png", Description = "Black Label beer", Price = 25.99m },
           new MenuItem { Id = 2, Name = "Spannish Cake", Icon = "cake.png", Description = "Struuuu berry vasdajld xcbbusdxydv", Price = 49.99m },
           new MenuItem { Id = 3, Name = "Cakepan", Icon = "cakepan.jpg", Description = "Freshly baked cakes", Price = 34.99m },
           new MenuItem { Id = 4, Name = "Corona 6pack", Icon = "coronabeer.png", Description = "jh,cvghd deudcgfdbe bcc", Price = 120.99m },
           new MenuItem { Id = 5, Name = "Italian ice-cream Cakes", Icon = "dessert.jpeg", Description = "Delicious italian cake", Price = 30.99m },
           new MenuItem { Id = 6, Name = "VIP dessert", Icon = "fulldessert.jpg", Description = "Rich chocolate dessert for rich people", Price = 249.99m },
           new MenuItem { Id = 7, Name = "Russian Kota", Icon = "headerkota.png", Description = "Delicious Kota", Price = 39.99m },
           new MenuItem { Id = 8, Name = "Black Label 500ml", Icon = "blacklabel.png", Description = "Dangerous don't drink and drive", Price = 18.99m },
           /*new MenuItem { Id = 9, Name = "Jack Danials", Icon = "jackisky.png", Description = "rfuykgfc sdsdgvedb n7edyged", Price = 300.49m },
           new MenuItem { Id = 10, Name = "Jonny Walker RedLabel", Icon = "jjwalker.png", Description = "Red Label for kings", Price = 500.49m },
           new MenuItem { Id = 11, Name = "Beef burger", Icon = "kotabegger.jpg", Description = " Beef burger o;hdfskb uhcdygk", Price = 26.99m },
           new MenuItem { Id = 12, Name = "Chicken Meal", Icon = "kotachickenmeal.jpg", Description = "Quick and tasty full meal", Price = 170.99m },
           new MenuItem { Id = 13, Name = "Japan burger", Icon = "kotajapan.jpg", Description = "Japannes burger", Price = 79.99m },
           new MenuItem { Id = 14, Name = "Large Kota", Icon = "kotalag.jpeg", Description = "large kota for friends", Price = 60.99m },
           new MenuItem { Id = 15, Name = "French burger", Icon = "kotamaxi.jpg", Description = "Crispy french burger", Price = 120.99m },
           new MenuItem { Id = 16, Name = "Kota (Medium)", Icon = "kotanormal.jpg", Description = "best kota", Price = 32.99m },
           new MenuItem { Id = 17, Name = "Audialle", Icon = "kotarec.jpeg", Description = "Sygdcgh nsdudsgsw diygsydg", Price = 1.49m },
           new MenuItem { Id = 18, Name = "Beacon and Chips", Icon = "kotasmall.jpg", Description = "Best Beacon and Chips", Price = 34.99m },
           new MenuItem { Id = 19, Name = "JonnyWalker BlackLabel", Icon = "jjwalkerblack.png", Description = "pre JonnyWalker BlackLabel", Price = 700.99m },
           new MenuItem { Id = 20, Name = "Castel Lager 360ml", Icon = "lagerbeer.png", Description = "cASTEL lAGER BEER ADG EDUIDYG", Price = 16.49m },
           new MenuItem { Id = 21, Name = "Oreo Cups", Icon = "oreodessertcups.jpg", Description = "Oreo Dessert Cup Cakes", Price = 50.99m },
           new MenuItem { Id = 22, Name = "Panna Cotta", Icon = "pannacotta.jpg", Description = "South Indian dessert", Price = 60.99m },
           new MenuItem { Id = 23, Name = "Heineken", Icon = "nekenbeer.png", Description = "Grilled kebab", Price = 29.99m },
           new MenuItem { Id = 24, Name = "Peanut Pie", Icon = "peanutbutterpretzelpie.jpg", Description = "Peanutbutter pretzel pie", Price = 49.99m },
           new MenuItem { Id = 25, Name = "Tiramisu Cheesecake", Icon = "tiramisucheesecake", Description = "Sweet cheesecake", Price = 70.99m },
           new MenuItem { Id = 26, Name = "Trifflecake", Icon = "home.png", Description = "Fresh sweet Trifflecake", Price = 43.99m },*/
           };
        }

        public static List<MenuItemCategoryMapping> GetMenuItemCategoryMappings()
        {
            return new List<MenuItemCategoryMapping>
            {
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 1 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 6 },
                /*new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 7 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 8 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 10 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 11 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 32 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 17 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 18 },
                new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 19 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 2 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 13 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 14 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 18 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 20 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 22 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 23 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 24 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 26 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 23 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 24 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 23 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 14 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 25 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 18 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 19 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 20 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 21 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 25 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 10 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 11 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 12 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 13 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 24 },
                new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 15 },
                new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 3 },
                new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 15 },
                new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 16 },
                new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 17 },
                new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 19 },
                new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 26 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 5 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 8 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 9 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 21 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 25 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 25 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 23 },
                new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 26 },*/
       
            };
        }
    }
}
