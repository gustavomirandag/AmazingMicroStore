using AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands;
using AmazingMicroStore.ProductMicroservice.Domain.Services;
using AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Contexts;
using AmazingMicroStore.ProductMicroservice.Infrastructure.DataAccess.Repositories.EFCore;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Service.WebJob
{
    public class Functions
    {
        private static CommandHandler _commandHandler;

        public Functions()
        {
            //Fake Dependency Injection
            _commandHandler = new CommandHandler(
                new ProductService(
                    new ProducRepository(
                        new ProductContext()
                    )
                )
            );
        }

        public static void ProcessAddProductCommandQueueMessage([QueueTrigger(AddProductCommand.ConstQueueName)] string message, ILogger logger)
        {
            logger.LogInformation($"{message}\n");

            var command = JsonConvert.DeserializeObject<AddProductCommand>(message);
            _commandHandler.Handle(command);
        }

        public static void ProcessUpdateProductCommandQueueMessage([QueueTrigger(UpdateProductCommand.ConstQueueName)] string message, ILogger logger)
        {
            logger.LogInformation($"{message}\n");

            var command = JsonConvert.DeserializeObject<UpdateProductCommand>(message);
            _commandHandler.Handle(command);
        }

        public static void ProcessDeleteProductCommandQueueMessage([QueueTrigger(DeleteProductCommand.ConstQueueName)] string message, ILogger logger)
        {
            logger.LogInformation($"{message}\n");

            var command = JsonConvert.DeserializeObject<DeleteProductCommand>(message);
            _commandHandler.Handle(command);
        }
    }
}
