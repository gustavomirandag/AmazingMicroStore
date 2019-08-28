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
    public class CatalogProductQueryEFCoreRepository : ICatalogProductQueryRepository
    {
        private CatalogProductContext _catalogProductContext;

        public CatalogProductQueryEFCoreRepository(CatalogProductContext catalogProductContext)
        {
            _catalogProductContext = catalogProductContext;
        }

        public CatalogProduct Get(Guid id)
        {
            return _catalogProductContext.CatalogProducts.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<CatalogProduct> GetAll()
        {
            return _catalogProductContext.CatalogProducts;
        }
    }
}
