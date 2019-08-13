using NetCoreMvcClear.Data.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Models
{
    public class Category : NamedEntity
    {
        public List<RentItem> RentItems { get; set; }
    }
}
