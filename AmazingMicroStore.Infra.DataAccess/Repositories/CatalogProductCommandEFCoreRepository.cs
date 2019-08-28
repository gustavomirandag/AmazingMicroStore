using AmazingMicroStore.Infra.DataAccess.Repositories.Contexts;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.CatalogProductAggregate;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AmazingMicroStore.Infra.DataAccess.Repositories
{
    public class CatalogProductCommandEFCoreRepository : ICatalogProductCommandRepository
    {
        private CatalogProductContext _catalogProductContext;

        public CatalogProductCommandEFCoreRepository(CatalogProductContext catalogProductContext)
        {
            _catalogProductContext = catalogProductContext;
        }

        public void Create(CatalogProduct catalogProduct)
        {
            _catalogProductContext.Add(catalogProduct);
        }

        public void Delete(Guid id)
        {
            var catalogProduct = _catalogProductContext
                .CatalogProducts.SingleOrDefault(p => p.Id == id);
            _catalogProductContext.Remove(catalogProduct);
        }

        public void Update(CatalogProduct catalogProduct)
        {
            _catalogProductContext.Entry<CatalogProduct>(catalogProduct)
                .State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void SaveChanges()
        {
            _catalogProductContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _catalogProductContext.SaveChangesAsync();
        }


    }
}
