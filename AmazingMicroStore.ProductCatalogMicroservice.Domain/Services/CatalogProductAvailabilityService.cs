using AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductCatalogMicroservice.Domain.Services
{
    public class CatalogProductAvailabilityService
    {
        private readonly ICatalogProductCommandRepository _catalogProductCommandRepository;

        public CatalogProductAvailabilityService(ICatalogProductCommandRepository catalogProductCommandRepository)
        {
            _catalogProductCommandRepository = catalogProductCommandRepository;
        }

        public void UpdateCatalogProductAvailability(CatalogProduct catalogProduct, bool isAvailable)
        {
            catalogProduct.CatalogProductStatus =
                isAvailable ? CatalogProductStatus.Available : CatalogProductStatus.Unavailable;
            _catalogProductCommandRepository.Update(catalogProduct);
            _catalogProductCommandRepository.SaveChanges();

        }
    }
}
