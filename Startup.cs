using Microsoft.Extensions.DependencyInjection;
using xUnit.TestAutomation.Module.Driver;
using xUnit.TestAutomation.Module.DriverInitializer;

namespace xUnit.TestAutomation.Module
{
    public class Startup
    {

        public void ConfigurationServices (IServiceCollection services) 
        {

            services.UseWebDriverInitializer(BrowserType.Chrome);
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IBrowserSettings, BrowserSettings>();
        


        }
    }
}
