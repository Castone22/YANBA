using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YANBA.Spec.PageObjects
{
    class PostPage
    {
        private readonly IWebDriver driver;


        public PostPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Id, Using = "post_content")]
        public IWebElement PostContent { get; set; }

        [FindsBy(How = How.Id, Using = "post_author")]
        public IWebElement PostAuthor { get; set; }

        [FindsBy(How = How.Id, Using = "post_date")]
        public IWebElement PostDate { get; set; }

        [FindsBy(How = How.Id, Using = "post_title")]
        public IWebElement PostTitle { get; set; }

    }
}
