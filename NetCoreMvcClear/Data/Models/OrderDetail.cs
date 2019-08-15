using NetCoreMvcClear.Data.Models.BaseModels;

namespace NetCoreMvcClear.Data.Models
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }

        public int RentItemId { get; set; }

        public uint Quantity { get; set; }

        public uint ItemPrice { get; set; }

        public virtual RentItem RentItem { get; set; }

        public virtual Order Order { get; set; }
    }
}