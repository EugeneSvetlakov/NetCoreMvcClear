using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<RentItem> availableItems { get; set; }
    }
}
