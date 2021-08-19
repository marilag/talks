using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MediatR;

namespace mentor.functions
{
    public class CreateMentor
    {
        private readonly IMediator _mediator;

        public CreateMentor(IMediator mediator)
        {
            _mediator = mediator;
        }
        [FunctionName("CreateMentor")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = "mentor")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var command = JsonConvert.DeserializeObject<mentor.commands.CreateMentor>(requestBody);
                        
            var commandResult = await _mediator.Send<mentor.commands.CreateMentor>(command);           

            return new OkObjectResult(commandResult);
        }
    }
}
