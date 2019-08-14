using NetCoreMvcClear.Data.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Models
{
    public class RentCartItem : BaseEntity
    {
        public RentItem RentItem { get; set; }

        public int Quantity { get; set; }

        public string RentCartId { get; set; }
    }
}
