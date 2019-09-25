using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands
{
    public class DeleteProductCommand : ProductCommand
    {
        public const string ConstQueueName = "delete-product-command-queue";
        public override string QueueName { get => ConstQueueName; }

        public DeleteProductCommand(Product product)
            :base(product)
        {
        }
    }
}
