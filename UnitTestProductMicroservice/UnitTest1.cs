using AmazingMicroStore.ProductMicroservice.Application;
using AmazingMicroStore.ProductMicroservice.Application.AppModel.DTO;
using AmazingMicroStore.ProductMicroservice.Application.AutoMapper;
using AmazingMicroStore.ProductMicroservice.Domain.Services;
using AmazingMicroStore.ProductMicroservice.Infrastructure.CQRS;
using AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Contexts;
using AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Repositories.EFCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProductMicroservice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductDTO product = new ProductDTO
            {
                Name = "Mouse",
                Price = 50,
                Quantity = 100
            };

            var dtoConfig = AutoMapperConfig.RegisterAllMappings();
            var mapper = dtoConfig.CreateMapper();

            var apiAppService = new ApiAppService(new RabbitMQueue(),
                mapper, new ProductService(new ProducRepository(
                    new ProductContext())));

            apiAppService.AddProduct(product);
        }
    }
}
