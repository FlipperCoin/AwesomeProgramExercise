using System;
using Microsoft.Extensions.Configuration;

namespace AwesomeProgram.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = GetConfig();
            Console.ReadLine();
        }

        private static Configuration GetConfig()
        {
            /*
             * Using .NET's ConfigurationBuilder to build configuration.
             * Can use YAML/JSON/XML files as well as environment variables and anything else that has ConfigurationBuilder support.
             */
            var configurationBuilder = new ConfigurationBuilder();
            
            configurationBuilder.AddYamlFile("app_config.yml", optional: true, reloadOnChange: true);

            IConfigurationRoot configurationRoot = configurationBuilder.Build();

            return configurationRoot.Get<Configuration>() ?? new Configuration();
        }
    }
}
