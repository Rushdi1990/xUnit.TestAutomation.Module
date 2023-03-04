using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using OpenQA.Selenium.DevTools.V107.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using xUnit.TestAutomation.Module.Driver;
using xUnit.TestAutomation.Module.Settings;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace xUnit.TestAutomation.Module.DriverInitializer
{
    public static class WebDriverInitializationExtension
    {
        public static IServiceCollection UseWebDriverInitializer(this IServiceCollection services, BrowserType browserType)

        {

            services.AddSingleton(new TestSettings
            {

                BrowserType= browserType,
            }

                );
            return services;

        }


      
/*
            private static AppSettings ReadConfig()
            {
                var configFile = File
                                .ReadAllText(Path.GetDirectoryName(
                                    Assembly.GetExecutingAssembly().Location)
                                + "/appsettings.json");

                var jsonSerializeOptions = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };

                jsonSerializeOptions.Converters.Add(new JsonStringEnumConverter());

                var testSettings = JsonSerializer.Deserialize<AppSettings>(configFile, jsonSerializeOptions);

                return testSettings;
            }*/





            /*   var dir = Path.Combine(
                  Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                  "json");

               foreach (var file in Directory.GetFiles(dir, "*.json"))
               {
                   var text = File.ReadAllText(file);
                   // Having a model makes it easy to convert the Json.
                   var model = JsonConvert.DeserializeObject<AppSettings>(text);
                   // Adding the model to the list will use the "ToString" method to display it.

               }*/






    }
}
