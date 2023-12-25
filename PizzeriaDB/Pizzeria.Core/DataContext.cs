using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Core.Entities;

namespace Pizzeria.Core
{
    public class DataContext:DbContext
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Waiters> Waiters => Set<Waiters>();
        public DbSet<Customers> Customers=> Set<Customers>();
        public DbSet<Dish> Dishes=> Set<Dish>();
        public DbSet<Orders> Orders=> Set<Orders>();
        public DbSet<Orders_Dishes> Orders_Dishes=> Set<Orders_Dishes>();
        public DbSet<Prices> Prices=> Set<Prices>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=PizzeriaDB;" +
                                        "Integrated Security=True; Encrypt=True; TrustServerCertificate=True\r\n");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
