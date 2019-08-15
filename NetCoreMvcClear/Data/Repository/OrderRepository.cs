using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly AppDbContent _AppDbContent;
        private readonly RentCart _RentCart;

        public OrderRepository(AppDbContent appDbContent, RentCart rentCart)
        {
            this._AppDbContent = appDbContent;
            this._RentCart = rentCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _AppDbContent.Orders.Add(order);

            var items = _RentCart.RentCartList;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    RentItemId = item.RentItem.Id,
                    OrderId = order.Id,
                    Quantity = item.Quantity,
                    ItemPrice = item.RentItem.RentPrice
                };

                _AppDbContent.OrderDetails.Add(orderDetail);
            }

            _AppDbContent.SaveChanges();
        }
    }
}
