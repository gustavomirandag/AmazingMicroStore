using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        void Create(Product product);
        Product Read(Guid id);
        IEnumerable<Product> ReadAll();
        void Update(Product product);
        void Delete(Guid id);
    }
}
