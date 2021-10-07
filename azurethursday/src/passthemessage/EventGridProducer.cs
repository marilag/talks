using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace passthemessage
{
    public  class EventGridProducer
    {
        private readonly IEventGridService eventGridService;
        public EventGridProducer(IEventGridService eventGridService)
        {
            this.eventGridService = eventGridService;
        }

        [FunctionName("events")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = null)] HttpRequest req,
            ILogger log)
        {
                       

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            var eventObj = JsonConvert.DeserializeObject<EventObject>(requestBody);
            await eventGridService.PublishEventsAsync(new List<EventGridMessage>() { 
                new EventGridMessage()
                {
                    Subject = eventObj.EventType, 
                    Data = eventObj,
                    DataVersion = "1.0",
                    Id = System.Guid.NewGuid().ToString()
                }
            });


            return new OkResult();
        }
    }
}
