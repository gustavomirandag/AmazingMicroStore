using AmazingMicroStore.Infra.DataAccess.Repositories;
using AmazingMicroStore.Infra.DataAccess.Repositories.Contexts;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.ProductAggregate;
using AmazingMicroStore.ProductCatalogMicroservice.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AmazingMicroStore.ProductCatalogMicroservice.Service.Api.Controllers
{
    //[Authorize(Roles ="admin")]
    public class CatalogProductsController : ApiController
    {
        private CatalogProductManagerService _catalogProductManager;
        private CatalogProductQueryService _catalogProductQueryService;

        public CatalogProductsController()
        {
            _catalogProductManager = new CatalogProductManagerService(
                new CatalogProductCommandEFCoreRepository(
                    new CatalogProductContext()));
            _catalogProductQueryService = new CatalogProductQueryService(
                new CatalogProductQueryEFCoreRepository(
                    new CatalogProductContext()));

        }

        // GET api/catalogproducts
        public IEnumerable<CatalogProduct> Get()
        {
            return _catalogProductQueryService.GetAllCatalogProducts();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/catalogproducts
        public void Post([FromBody]CatalogProduct catalogProduct)
        {
            _catalogProductManager.AddCatalogProduct(catalogProduct);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
