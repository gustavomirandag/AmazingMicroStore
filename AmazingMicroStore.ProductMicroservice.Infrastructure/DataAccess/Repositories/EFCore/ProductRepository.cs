using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AmazingMicroStore.ProductMicroservice.Domain.Interfaces.Repositories;

namespace AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Repositories.EFCore
{
    public class ProducRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProducRepository(ProductContext context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _context.Products.Remove(Read(id));
            _context.SaveChanges();
        }

        public Product Read(Guid id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<Product> ReadAll()
        {
            return _context.Products;
        }

        public void Update(Product product)
        {
            Delete(product.Id);
            Create(product);
            _context.SaveChanges();
        }
    }
}
