using AmazingMicroStore.ProductMicroservice.Domain.CQRS;
using AmazingMicroStore.ProductMicroservice.Domain.Interfaces.CQRS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingMicroStore.ProductMicroservice.Infrastructure.CQRS
{
    public class AzureServiceBusQueue : IQueue
    {
        public string Dequeue(string queueName)
        {
            throw new NotImplementedException();
        }

        public Task<string> DequeueAsync(string queueName)
        {
            throw new NotImplementedException();
        }

        public void Enqueue(QueueMessage message)
        {
            throw new NotImplementedException();
        }

        public Task EnqueueAsync(QueueMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
