using NetCoreMvcClear.Data.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Models
{
    public class RentItem : NamedEntity
    {
        public string BrandName { get; set; }

        public bool IsAvailable { get; set; }

        public ushort Size { get; set; }

        public ushort RentPrice { get; set; }

        public string ImgUrl { get; set; }

        public int categoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
