using AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate
{
    public class CatalogProduct
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public int OffersQuantity { get; set; }
        public decimal MinimumPrice { get; set; }
        public CatalogProductStatus CatalogProductStatus { get; set; }
    }
}
