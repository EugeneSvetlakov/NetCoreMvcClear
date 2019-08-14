using Microsoft.AspNetCore.Mvc;
using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRentItem _rentItem;

        public HomeController(IRentItem rentItem)
        {
            _rentItem = rentItem;
        }

        public ViewResult Index()
        {
            var homeItems = new HomeViewModel
            {
                availableItems = _rentItem.GetAvailableRentItems
            };

            return View(homeItems);
        }
    }
}
