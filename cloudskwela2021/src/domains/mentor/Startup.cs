using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MediatR;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Http;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using mentor;
using shared;

[assembly: FunctionsStartup(typeof(Startup))]
namespace mentor
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var configBuilder = new ConfigurationBuilder()
        .SetBasePath(System.Environment.CurrentDirectory)
        .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
        .AddEnvironmentVariables();

            var config = configBuilder.Build();

            configBuilder.AddAzureKeyVault(
                $"https://eturokeyv.vault.azure.net/"
            );

            config = configBuilder.Build();

            builder.Services.Replace(ServiceDescriptor.Singleton(typeof(IConfiguration), config));
            builder.Services.AddSingleton<ICosmosDBSQLService, CosmosDBSQLService>();
            builder.Services.Configure<CosmosDBSQLOptions>(cosmosoptions =>
            {
                cosmosoptions.EndpointUri = config["CosmosDb:EndpointUri"];
                cosmosoptions.Key = config["CosmosKey"];
                cosmosoptions.Database = config["CosmosDb:Database"];
                cosmosoptions.DefaultRU = int.Parse(config["CosmosDb:DefaultRU"]);
            });
            builder.Services.AddSingleton<IEventGridService, EventGridService>();
            builder.Services.Configure<EventGridOptions>(eventgridoptions => config.GetSection("EventGrid"));
            builder.Services.Configure<EventGridOptions>(option => {
                option.TopicEndpoint = config["EventGrid:TopicEndpoint"];
                option.Key = config["EventGridKey"];
            });

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

        }

    }
}

