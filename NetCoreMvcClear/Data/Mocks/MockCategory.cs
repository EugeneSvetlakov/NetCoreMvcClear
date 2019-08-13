using NetCoreMvcClear.Data.Interfaces;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Лыжи", Desc = "Обычные лыжи"},
                    new Category { Name = "Ботинки Лыжные", Desc = "Обычные лыжные бтинки"}
                };
            }
        }
        
    }
}
