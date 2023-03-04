using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace xUnit.TestAutomation.Module.Driver
{
    public interface IBrowserSettings
    {
        IWebDriver GetChromeDriver();
        IWebDriver GetFirefoxDriver();
    }

    public class BrowserSettings : IBrowserSettings
    {
        public IWebDriver GetChromeDriver()
        {
            /*ChromeOptions options = new ChromeOptions();
            // options.AddArguments("headless");
            options.AddArguments("disable-infobars");
            options.AddArguments("--disable-gpu");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--no-sandbox");
            options.AddArguments("--disable-dev-shm-usage");
            options.AddArguments("--window-size=1920,1080");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("force-device-scale-factor=1");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--user-agent=Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.5195.127 Safari/537.36");
           */
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }


        public IWebDriver GetFirefoxDriver()
        {
          /*  FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("headless");
            options.AddArguments("allow-insecure-localhost");*/
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();


        }

        

    }


}
public enum BrowserType

{
    Chrome,
    Firefox

}