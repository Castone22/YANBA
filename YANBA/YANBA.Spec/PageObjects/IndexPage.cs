using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YANBA.Spec.PageObjects
{
    class IndexPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"http://localhost:51991/";


        public IndexPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }
    }
}
