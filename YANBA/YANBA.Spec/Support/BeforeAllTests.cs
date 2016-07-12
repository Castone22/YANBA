using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace YANBA.Spec.Support
{
    [Binding]
    public class BeforeAllTests
    {
        private readonly IObjectContainer objectContainer;
        private static SeleniumContext seleniumContext;

        public BeforeAllTests(IObjectContainer container)
        {
            this.objectContainer = container;
        }

        [BeforeTestRun]
        public static void RunBeforeAllTests()
        {
            seleniumContext = new SeleniumContext();
        }

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            objectContainer.RegisterInstanceAs<SeleniumContext>(seleniumContext);
        }

        [AfterTestRun]
        public void RunAfterAllTests()
        {
            seleniumContext.WebDriver.Close();
        }
    }
}
