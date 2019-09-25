using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands
{
    public class UpdateProductCommand : ProductCommand
    {
        public const string ConstQueueName = "update-product-command-queue";
        public override string QueueName { get => ConstQueueName; }
        public UpdateProductCommand(Product product)
            :base(product)
        {
        }
    }
}
