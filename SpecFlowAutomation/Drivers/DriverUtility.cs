using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Drivers
{
    public class DriverUtility
    {
        public static IWebDriver driver = new EdgeDriver();

        public static IWebDriver ConnectToBrowser()
        {
            try
            {
                driver.Navigate().GoToUrl("https://www.google.com/");
                driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
                driver.Manage().Window.Maximize();

            }
            catch (Exception)
            {

                throw;
            }
            return driver;
        }
    }
}
