using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DeliveryHeroAutomation.Framework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            var environment = Environment.GetEnvironmentVariable("DeliveryHero");
            var currentDirectory = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                .SetBasePath(currentDirectory)
                .AddJsonFile("appsettings.json");
            var config = builder.Build();

            var appConfig = config.GetSection("TestAndroidSettings").Get<TestSettings>();

            Setting.TestSettings = appConfig;
            var appPath = Path.Combine(currentDirectory, appConfig.App);
            Setting.TestSettings.App = appPath;
        }
    }
}