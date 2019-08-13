using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.ViewModels
{
    public class RentItemViewModel
    {
        public IEnumerable<RentItem> GetAllRentItems { get; set; }

        public string currentCategory { get; set; }
    }
}
