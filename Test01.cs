using OpenQA.Selenium;
using xUnit.TestAutomation.Module.Driver;


namespace xUnit.TestAutomation.Module
{
    public class Test01
    {

        IWebDriver driver;


        public Test01(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
            driver.Navigate().GoToUrl(new Uri("https://www.google.com"));
        }


        [Fact]
        public void Test1()
        {




        }



    }
}
