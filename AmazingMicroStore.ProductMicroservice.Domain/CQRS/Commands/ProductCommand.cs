using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands
{
    public abstract class ProductCommand : Command
    {
        public Product Product { get; set; }

        protected ProductCommand(Product product)
        {
            Product = product;
        }
    }
}
