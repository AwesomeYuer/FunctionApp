using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp.Functions
{
    public static class QueueTriggerFunction
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("queue1-items", Connection = "Queue1")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
