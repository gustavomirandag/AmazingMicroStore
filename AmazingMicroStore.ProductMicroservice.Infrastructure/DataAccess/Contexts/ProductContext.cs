using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using AmazingMicroStore.ProductMicroservice.Infrastructure.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Contexts
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(Resources.DbConnectionString);
        }
    }
}
