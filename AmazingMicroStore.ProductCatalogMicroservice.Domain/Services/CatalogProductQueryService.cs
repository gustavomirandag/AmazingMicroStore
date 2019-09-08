using AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductCatalogMicroservice.Domain.Services
{
    public class CatalogProductQueryService
    {
        private readonly ICatalogProductQueryRepository _catalogProductQueryRepository;

        public CatalogProductQueryService(ICatalogProductQueryRepository catalogProductQueryRepository)
        {
            _catalogProductQueryRepository = catalogProductQueryRepository;
        }

        public IEnumerable<CatalogProduct> GetAllCatalogProducts()
        {
            return _catalogProductQueryRepository.GetAll();
        }
    }
}
