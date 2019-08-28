using AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductCatalogMicroservice.Domain.Services
{
    public class CatalogProductManagerService
    {
        private readonly ICatalogProductCommandRepository _catalogProductCommandRepository;

        public CatalogProductManagerService(ICatalogProductCommandRepository catalogProductCommandRepository)
        {
            _catalogProductCommandRepository = catalogProductCommandRepository;
        }

        public void AddCatalogProduct(CatalogProduct catalogProduct)
        {
            _catalogProductCommandRepository.Create(catalogProduct);
            _catalogProductCommandRepository.SaveChanges();
        }
    }
}
