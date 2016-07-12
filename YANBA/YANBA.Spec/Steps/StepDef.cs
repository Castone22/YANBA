using System;
using TechTalk.SpecFlow;
using YANBA.Spec.PageObjects;
using YANBA.Spec.Support;

namespace YANBA.Spec.Steps
{
    [Binding]
    public class StepDef
    {
        private SeleniumContext seleniumContext;

        public StepDef(SeleniumContext seleniumContext)
        {
            this.seleniumContext = seleniumContext;
        }

        [Given(@"my favorite blogger has been very active")]
        public void GivenMyFavoriteBloggerHasBeenVeryActive()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I visit the blog for my favorite blogger")]
        public void GivenIVisitTheBlogForMyFavoriteBlogger()
        {
            seleniumContext.WebDriver.Navigate().GoToUrl("https://google.com");
        }
        
        [When(@"I visit the blog for my favorite blogger")]
        public void WhenIVisitTheBlogForMyFavoriteBlogger()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I choose a blog post")]
        public void WhenIChooseABlogPost()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for a blog post")]
        public void WhenISearchForABlogPost()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"then I should see a summary of my favorite blogger's (.*) most recent posts in reverse order")]
        public void ThenThenIShouldSeeASummaryOfMyFavoriteBloggerSMostRecentPostsInReverseOrder(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the blog post")]
        public void ThenIShouldSeeTheBlogPost()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see posts with that value in the title")]
        public void ThenIShouldSeePostsWithThatValueInTheTitle()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see comments left by other readers")]
        public void ThenIShouldSeeCommentsLeftByOtherReaders()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am reading a blog post from my favorite blogger")]
        public void GivenIAmReadingABlogPostFromMyFavoriteBlogger()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I add my genius comment to the blog post")]
        public void WhenIAddMyGeniusCommentToTheBlogPost()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"my genius comment is at the top of the blog post comments")]
        public void ThenMyGeniusCommentIsAtTheTopOfTheBlogPostComments()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the url should contain information about the post")]
        public void ThenTheUrlShouldContainInformationAboutThePost()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am logged in as a blogger")]
        public void GivenIAmLoggedInAsABlogger()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I publish a new blog post")]
        public void WhenIPublishANewBlogPost()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am notified that the blog post was successfully added")]
        public void ThenIAmNotifiedThatTheBlogPostWasSuccessfullyAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the newly added blog post is at the top of the recent posts list")]
        public void ThenTheNewlyAddedBlogPostIsAtTheTopOfTheRecentPostsList()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
