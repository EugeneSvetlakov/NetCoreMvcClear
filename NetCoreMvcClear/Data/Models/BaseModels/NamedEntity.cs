using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Models.BaseModels
{
    public class NamedEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        
    }
}
