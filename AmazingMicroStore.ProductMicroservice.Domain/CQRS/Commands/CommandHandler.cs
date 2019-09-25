using AmazingMicroStore.ProductMicroservice.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands
{
    public class CommandHandler
    {
        private readonly ProductService _productService;

        public CommandHandler(ProductService productService)
        {
            _productService = productService;
        }

        public void Handle(AddProductCommand command)
        {
            _productService.AddProduct(command.Product);
        }

        public void Handle(UpdateProductCommand command)
        {
            _productService.UpdateProduct(command.Product);
        }

        public void Handle(DeleteProductCommand command)
        {
            _productService.DeleteProduct(command.Product.Id);
        }
    }
}
