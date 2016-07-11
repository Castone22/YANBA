using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace YANBA.Spec.Support
{
    [Binding]
    public sealed class Hooks
    {
        private static IWebDriver driver { get; set; }
        public static readonly string HOME_URL = @"http://localhost:51991/";
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
