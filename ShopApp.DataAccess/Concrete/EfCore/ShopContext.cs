using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Conrete.EfCore
{
   public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9JQOHOM;Database=ShopDb; Trusted_Connection=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Card> Cards{ get; set; } //Not zaten card  içerisinde cardıtem de olduğu için altta  carditem tanımlaasakta database carditem eklenecektir.
        public DbSet<CardItem> CardItems{ get; set; } //Not zaten card  içerisinde cardıtem de olduğu için altta  carditem tanımlaasakta database carditem eklenecektir.
        public DbSet<Order> Orders{ get; set; } //Not zaten card  içerisinde cardıtem de olduğu için altta  carditem tanımlaasakta database carditem eklenecektir.
        // Test içindir
        public DbSet<Review> Reviews{ get; set; } 

    }
}
