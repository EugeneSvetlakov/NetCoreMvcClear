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
    public class RentCartController : Controller
    {
        private readonly IRentItem _rentItem;
        private readonly RentCart _rentCart;

        public RentCartController(IRentItem rentItem, RentCart rentCart)
        {
            _rentItem = rentItem;
            _rentCart = rentCart;
        }

        public ViewResult Index()
        {
            var items = _rentCart.getRentItems();
            _rentCart.RentCartList = items;

            var obj = new RentCartViewModel
            {
                rentCart = _rentCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _rentItem.AllRentItems.FirstOrDefault(i => i.Id == id);

            if(item != null)
            {
                _rentCart.AddToCart(item, 1);
            }
            return RedirectToAction("Index");
        }
    }
}
