using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //DB tabloları ile proje classlarını bağlamak için kullanılır. Context.
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server = Ip ver");
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-S4MQ2TQ ;Database = Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }




    }
}
