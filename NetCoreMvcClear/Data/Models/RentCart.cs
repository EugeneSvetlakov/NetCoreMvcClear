using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetCoreMvcClear.Data.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Models
{
    public class RentCart : BaseEntity
    {
        private readonly AppDbContent appDbContent;

        public RentCart(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public string RentCartId { get; set; }

        public List<RentCartItem> RentCartList { get; set; }

        /// <summary>
        /// Получить корзину к текущей сессии
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static RentCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDbContent>();

            string rentCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", rentCartId);

            return new RentCart(context) { RentCartId = rentCartId };
        }

        public void AddToCart(RentItem rentItem, int quantity)
        {
            this.appDbContent.RentCartItems.Add(new RentCartItem
            {
                RentCartId = RentCartId, RentItem = rentItem, Quantity = quantity
            });

            appDbContent.SaveChanges();
        }

        public List<RentCartItem> getRentItems()
        {
            return appDbContent.RentCartItems.Where(c => c.RentCartId == RentCartId).Include(s => s.RentItem).ToList();
        }
    }
}
