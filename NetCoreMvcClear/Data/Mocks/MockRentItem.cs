using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Mocks
{
    public class MockRentItem : IRentItem
    {
        private readonly ICategory _categories = new MockCategory();

        public IEnumerable<RentItem> AllRentItems
        {
            get
            {
                return new List<RentItem>
                {
                    new RentItem {
                        Name = "Кукарамба 2",
                        BrandName = "Марий Эл",
                        IsAvailable = true,
                        Size = 175,
                        RentPrice = 450,
                        Category = _categories.AllCategories.First(),
                        ImgUrl = "/img/items/cccr11.jpg"
                    },
                    new RentItem {
                        Name = "FlashSky New",
                        BrandName = "Fisher",
                        IsAvailable = true,
                        Size = 195,
                        RentPrice = 450,
                        Category = _categories.AllCategories.First(),
                        ImgUrl = "/img/items/LS-Combi1.jpg"
                    },
                    new RentItem {
                        Name = "FlashSky Old",
                        BrandName = "Fisher",
                        IsAvailable = false,
                        Size = 195,
                        RentPrice = 450,
                        Category = _categories.AllCategories.First(),
                        ImgUrl = "/img/items/LS-Combi1.jpg"
                    },
                    new RentItem {
                        Name = "Boots Old",
                        BrandName = "Fisher",
                        IsAvailable = true,
                        Size = 42,
                        RentPrice = 250,
                        Category = _categories.AllCategories.Last(),
                        ImgUrl = "/img/items/bootsFisherNew.jpg"
                    },
                    new RentItem {
                        Name = "Boots New",
                        BrandName = "Fisher",
                        IsAvailable = true,
                        Size = 42,
                        RentPrice = 250,
                        Category = _categories.AllCategories.Last(),
                        ImgUrl = "/img/items/gl1.jpg"
                    }
                };
            }
        }

        public IEnumerable<RentItem> GetAvailableRentItems => throw new NotImplementedException();

        public RentItem GetRentItem(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
