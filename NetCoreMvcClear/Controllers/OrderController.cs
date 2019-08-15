using Microsoft.AspNetCore.Mvc;
using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrder _Order;
        private readonly RentCart _RentCart;

        public OrderController(IOrder order, RentCart rentCart)
        {
            this._Order = order;
            this._RentCart = rentCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _RentCart.RentCartList = _RentCart.getRentItems();

            if(_RentCart.RentCartList.Count == 0)
            {
                ModelState.AddModelError("", "В корзине нет товаров");
            }

            if (ModelState.IsValid)
            {
                _Order.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
