using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate
{
    public interface ICatalogProductQueryRepository
    {
        IEnumerable<CatalogProduct> GetAll();
        CatalogProduct Get(Guid id);
    }
}
