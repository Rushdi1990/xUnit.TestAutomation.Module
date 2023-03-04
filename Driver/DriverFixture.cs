using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit.TestAutomation.Module.DriverInitializer;
using xUnit.TestAutomation.Module.Settings;

namespace xUnit.TestAutomation.Module.Driver
{

    public interface IDriverFixture 
    {
    
        IWebDriver Driver { get; }
    
    }


    public class DriverFixture : IDriverFixture
    {

        IWebDriver driver;
        public readonly IBrowserSettings browserSettings;
        public readonly TestSettings testSettings;

        public DriverFixture(IBrowserSettings browserSettings, TestSettings testSettings) 
        {
            this.testSettings = testSettings;
            this.browserSettings = browserSettings;
         
            driver = GetWebDriver();
       



        }

        public IWebDriver Driver => driver;

        public IBrowserSettings BrowserSettings { get; }

        private IWebDriver GetWebDriver()
        {

/*            if (BrowserTypes.Chrome.Equals(true))
            {
                chromeDriverSettings.GetChromeDriver();

                return appSettings.browserTypes();

            } else if( BrowserTypes.Firefox.Equals(true)) {

            return firefoxDriverSettings.GetFirefoxDriver();

            }*/


            return testSettings.BrowserType switch
            {

                BrowserType.Chrome => BrowserSettings.GetChromeDriver(),
                BrowserType.Firefox => BrowserSettings.GetFirefoxDriver(),
                _ => BrowserSettings.GetChromeDriver()
            };


        }





    }
}
