using DataDrivenWithExamples.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithExamples.StepDefinition
{
    [Binding]
    public class DataDrivenWithExamplesSteps
    {
        DataDrivenWithExamplesPage datadrivenwithexamplesPage;

        public DataDrivenWithExamplesSteps()
        {
            datadrivenwithexamplesPage = new DataDrivenWithExamplesPage();
        }


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            datadrivenwithexamplesPage.NavigateToWebsite(url);
        }
        
        [When(@"the User enter username text ""(.*)""")]
        public void WhenTheUserEnterUsernameText(string Username)
        {
            datadrivenwithexamplesPage.EnterUsername(Username);
        }
        
        [When(@"the user enter email text ""(.*)""")]
        public void WhenTheUserEnterEmailText(string Email)
        {
            datadrivenwithexamplesPage.EnterEmail(Email);
        }
        
        [When(@"the user enter password text ""(.*)""")]
        public void WhenTheUserEnterPasswordText(string Password)
        {
            datadrivenwithexamplesPage.EnterPassword(Password);
        }
    }
}
