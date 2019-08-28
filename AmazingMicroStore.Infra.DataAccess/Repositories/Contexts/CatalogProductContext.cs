using AmazingMicroStore.Infra.DataAccess.Properties;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.Infra.DataAccess.Repositories.Contexts
{
    public class CatalogProductContext : DbContext
    {
        public DbSet<CatalogProduct> CatalogProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(Resources.DbConnectionString);
        }

        public CatalogProductContext()
        {
            //Database.EnsureCreated();
        }
    }
}
