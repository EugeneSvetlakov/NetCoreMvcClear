using Microsoft.AspNetCore.Mvc;
using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.Data.Models;
using NetCoreMvcClear.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Controllers
{
    public class RentItemController : Controller
    {
        private readonly IRentItem _RentItems;
        private readonly ICategory _Categories;

        public RentItemController(IRentItem iRentItems, ICategory iCategories)
        {
            _RentItems = iRentItems;
            _Categories = iCategories;
        }

        [Route("RentItem/List")]
        [Route("RentItem/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<RentItem> rentItems;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                rentItems = _RentItems.AllRentItems.OrderBy(i => i.Id);
            }
            else
            {
                if(string.Equals("skyboots", category, StringComparison.OrdinalIgnoreCase))
                {
                    rentItems = _RentItems.AllRentItems.Where(i => i.Category.Name.Equals("Ботинки Лыжные")).OrderBy(i => i.Id);
                    currCategory = "Ботинки Лыжные";
                }
                else
                {
                    rentItems = _RentItems.AllRentItems.Where(i => i.Category.Name.Equals("Лыжи")).OrderBy(i => i.Id);
                    currCategory = "Лыжи";
                }
            }

            var rentObj = new RentItemViewModel
            {
                GetAllRentItems = rentItems,
                currentCategory = currCategory
            };

            ViewBag.Title = "На прокат";
            
            return View(rentObj);
        }
    }
}
