using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent content)
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.RentItems.Any())
            {
                content.RentItems.AddRange(
                    new RentItem
                    {
                        Name = "Кукарамба 2",
                        BrandName = "Марий Эл",
                        IsAvailable = true,
                        Size = 175,
                        RentPrice = 450,
                        Category = Categories["Лыжи"],
                        ImgUrl = "/img/items/cccr11.jpg"
                    },
                    new RentItem
                    {
                        Name = "FlashSky New",
                        BrandName = "Fisher",
                        IsAvailable = true,
                        Size = 195,
                        RentPrice = 450,
                        Category = Categories["Лыжи"],
                        ImgUrl = "/img/items/LS-Combi1.jpg"
                    },
                    new RentItem
                    {
                        Name = "FlashSky Old",
                        BrandName = "Fisher",
                        IsAvailable = false,
                        Size = 195,
                        RentPrice = 450,
                        Category = Categories["Лыжи"],
                        ImgUrl = "/img/items/LS-Combi1.jpg"
                    },
                    new RentItem
                    {
                        Name = "Boots Old",
                        BrandName = "Fisher",
                        IsAvailable = true,
                        Size = 42,
                        RentPrice = 250,
                        Category = Categories["Ботинки Лыжные"],
                        ImgUrl = "/img/items/bootsFisherNew.jpg"
                    },
                    new RentItem
                    {
                        Name = "Boots New",
                        BrandName = "Fisher",
                        IsAvailable = true,
                        Size = 42,
                        RentPrice = 250,
                        Category = Categories["Ботинки Лыжные"],
                        ImgUrl = "/img/items/gl1.jpg"
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Лыжи", Desc = "Обычные лыжи"},
                        new Category { Name = "Ботинки Лыжные", Desc = "Обычные лыжные бтинки"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category item in list)
                    {
                        category.Add(item.Name, item);
                    }
                }
                return category;
            }
        }
    }
}
