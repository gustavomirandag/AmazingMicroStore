using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands
{
    public class AddProductCommand : ProductCommand
    {
        public const string ConstQueueName = "add-product-command-queue";
        public override string QueueName { get => ConstQueueName; }

        public AddProductCommand(Product product)      
            :base(product)
        {
        }
    }
}
