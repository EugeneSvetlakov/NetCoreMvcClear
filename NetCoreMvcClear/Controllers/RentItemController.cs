using Microsoft.AspNetCore.Mvc;
using NetCoreMvcClear.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Страница со списком проката";
            RentItemViewModel obj = new RentItemViewModel();
            obj.GetAllRentItems = _RentItems.AllRentItems;
            obj.currentCategory = "список единиц:";

            return View(obj);
        }
    }
}
