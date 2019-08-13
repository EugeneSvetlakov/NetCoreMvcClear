using Microsoft.EntityFrameworkCore;
using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Repository
{
    public class RentItemRepository : IRentItem
    {
        private readonly AppDbContent appDbContent;

        public RentItemRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<RentItem> AllRentItems => appDbContent.RentItems.Include(c => c.Category);

        public IEnumerable<RentItem> getAvailableRentItems => appDbContent.RentItems.Where(p => p.IsAvailable).Include(c => c.Category);

        public RentItem GetRentItem(int Id) => appDbContent.RentItems.FirstOrDefault(p => p.Id == Id);
    }
}
