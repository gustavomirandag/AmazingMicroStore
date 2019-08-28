using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate
{
    public interface ICatalogProductCommandRepository
    {
        void Create(CatalogProduct catalogProduct);
        void Update(CatalogProduct catalogProduct);
        void Delete(Guid id);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
