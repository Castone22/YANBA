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


        [FindsBy(How = How.Id, Using = "login_form_user_box")]
        public IWebElement LoginFormUserBox { get; set; }

        [FindsBy(How = How.Id, Using = "login_form_passsword_box")]
        public IWebElement LoginFormPasswordBox { get; set; }

        [FindsBy(How = How.Id, Using = "login_form_submit_button")]
        public IWebElement LoginFormSubmitButton { get; set; }



        [FindsBy(How = How.Id, Using = "search_text_box")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "search_submit_button")]
        public IWebElement SearchSubmitButton { get; set; }



        [FindsBy(How = How.Id, Using = "post_summary_text_")]
        public IWebElement PostSummaryText { get; set; }

        [FindsBy(How = How.Id, Using = "post_link_")]
        public IWebElement PostList { get; set; }

        [FindsBy(How = How.Id, Using = "post_author_")]
        public IWebElement PostAuthor { get; set; }

        [FindsBy(How = How.Id, Using = "post_date_")]
        public IWebElement PostDate { get; set; }

        [FindsBy(How = How.Id, Using = "post_title_")]
        public IWebElement PostTitle { get; set; }

    }
}
