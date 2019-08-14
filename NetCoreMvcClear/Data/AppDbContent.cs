using Microsoft.EntityFrameworkCore;
using NetCoreMvcClear.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data
{
    public class AppDbContent : DbContext
    {
        //Создание миграции: dotnet ef migrations add InitialCreate --project .\NetCoreMvcClear
        // Обновление БД: dotnet ef database update --project .\NetCoreMvcClear

        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {

        }

        public DbSet<RentItem> RentItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<RentCartItem> RentCartItems { get; set; }

        //public DbSet<RentCart> RentCarts { get; set; }
    }
}
