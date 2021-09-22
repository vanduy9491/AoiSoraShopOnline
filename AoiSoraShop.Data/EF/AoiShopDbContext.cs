using AoiSoraShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AoiSoraShop.Data.EF
{
    public class AoiShopDbContext : DbContext
    {
        public AoiShopDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Transaction> Transactions { get; set; }


    }
}
