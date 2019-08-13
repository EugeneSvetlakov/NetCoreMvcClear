using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Interfaces
{
    public interface IRentItem
    {
        IEnumerable<RentItem> AllRentItems { get; }
        IEnumerable<RentItem> getAvailableRentItems { get; }
        RentItem GetRentItem(int Id);
    }
}
