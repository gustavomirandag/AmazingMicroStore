using AmazingMicroStore.ProductMicroservice.Domain.Interfaces.Repositories;
using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product)
        {
            _repository.Create(product);
        }

        public void UpdateProduct(Product product)
        {
            _repository.Update(product);
        }

        public void DeleteProduct(Guid id)
        {
            _repository.Delete(id);
        }

        public Product GetProduct(Guid id)
        {
            return _repository.Read(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.ReadAll();
        }
    }
}
