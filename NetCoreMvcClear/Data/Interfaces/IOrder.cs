using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Interfaces
{
    public interface IOrder
    {
        void CreateOrder(Order order);
    }
}
