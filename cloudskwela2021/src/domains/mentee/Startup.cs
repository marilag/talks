using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MediatR;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Http;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using mentee;

[assembly: FunctionsStartup(typeof(Startup))]
namespace mentee
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
          

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

        }

    }
}

