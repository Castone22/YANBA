using System;
using TechTalk.SpecFlow;

namespace YANBA.Spec.Steps
{
    [Binding]
    public class StepDef
    {
        [Given(@"my favorite blogger has been very active")]
        public void GivenMyFavoriteBloggerHasBeenVeryActive()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I visit the blog for my favorite blogger")]
        public void GivenIVisitTheBlogForMyFavoriteBlogger()
        {
            ScenarioContext.Current.Pending();
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
    }
}
