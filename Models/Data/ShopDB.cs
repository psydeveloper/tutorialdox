using ShoppingCart.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class ShopDB : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ShopDB>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User_number> user_number { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Country_info> country_info { get; set; }
        

        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShopDB, Configuration>());
        }
    }
}