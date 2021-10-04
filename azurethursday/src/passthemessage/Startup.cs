using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

[assembly: FunctionsStartup(typeof(passthemessage.Startup))]
namespace passthemessage
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            var serviceProvider = builder.Services.BuildServiceProvider();
            var existingConfig = serviceProvider.GetService<IConfiguration>();


            var configBuilder = new ConfigurationBuilder()
           .SetBasePath(System.Environment.CurrentDirectory)
           .AddConfiguration(existingConfig)
           .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)           
           .AddEnvironmentVariables();
                

            var config = configBuilder.Build();

            configBuilder.AddAzureKeyVault(
                $"https://{config["AzureKeyVault:VaultName"]}.vault.azure.net/"
            );

            config = configBuilder.Build();

            builder.Services.Replace(ServiceDescriptor.Singleton(typeof(IConfiguration), config));
            
            builder.Services.AddSingleton<IEventGridService, EventGridService>();
            builder.Services.Configure<EventGridOptions>(option => {
                option.TopicEndpoint = config["EventGrid:TopicEndpoint"];
                option.Key = config["EventGridKey"];
            });
        }

    }
}