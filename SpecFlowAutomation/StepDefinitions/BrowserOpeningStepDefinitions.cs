using OpenQA.Selenium;
using SpecFlowAutomation.Drivers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class BrowserOpeningStepDefinitions
    {
        public static IWebDriver? _driver;

        //public BrowserOpeningStepDefinitions(IWebDriver driver)
        //{
        //    _driver= driver;
        //}


        [Given("open browser and enter google url")]
        public void open_browser_and_enter_google_url()
        {
            _driver = DriverUtility.ConnectToBrowser();
        }
    }
}
