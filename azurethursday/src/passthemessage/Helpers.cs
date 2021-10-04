using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace passthemessage
{
    public static class Helpers
    {

        public static config GetConfig(ExecutionContext context)
        {
            var config = new ConfigurationBuilder()
           .SetBasePath(context.FunctionAppDirectory)
           .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .Build();
        }
    }
}
