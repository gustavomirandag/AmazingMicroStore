using AmazingMicroStore.ProductMicroservice.Application.AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AmazingMicroStore.ProductMicroservice.Service.Api.Contexts
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductDTO> Products { get; set; }

        public ProductContext()
            :base("Server=tcp:productmicroservice-db-server.database.windows.net,1433;Initial Catalog=ProductMicroservice-Db;Persist Security Info=False;User ID=ale;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
        }
    }
}