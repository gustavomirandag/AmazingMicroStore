using AmazingMicroStore.ProductMicroservice.Domain.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands
{
    public abstract class Command : QueueMessage
    {
    }
}
