using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YANBA.Spec.Support
{
    public class SeleniumContext
    {
        public SeleniumContext()
        {
            WebDriver = new ChromeDriver();
        }

        public IWebDriver WebDriver { get; private set; }
    }
}
