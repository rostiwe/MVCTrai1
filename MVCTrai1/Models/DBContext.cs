using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCTrai1.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Toys> Toys { get; set; }
        public DbSet<Purchase> purchases { get; set; }


    }
    public class ToysDbInitializer : DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Toys.Add(new Toys { ToyId = 1, Gender = "Male", Manufacturer = "Lego", Name = "Fire Bionicle", Price = 9.58M });
            context.Toys.Add(new Toys { ToyId = 2, Gender = "Male", Manufacturer = "Lego", Name = "Fire Bionicle", Price = 9.58M });
            context.Toys.Add(new Toys { ToyId = 3, Gender = "Male", Manufacturer = "Lego", Name = "Fire Bionicle", Price = 9.58M });
            context.Toys.Add(new Toys { ToyId = 4, Gender = "FeMale", Manufacturer = "Lego", Name = "Fire Bionicle", Price = 16.50M });
            context.purchases.Add(new Purchase { Customer = "Я", PurchaseId = 1, Date = DateTime.Now, ToyId = 1 });
            base.Seed(context);
        }
    }
}