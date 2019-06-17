using HOME_PAGE.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HOME_PAGE.StepDefinition
{
    [Binding]
    public class InformationAboutTheWebsiteSteps
    {
        InformationAboutWebsitePage informationaboutTheWebsite;

        public InformationAboutTheWebsiteSteps()
        {
            informationaboutTheWebsite = new InformationAboutWebsitePage();
        }
        [When(@"i click on learn more about us")]
        public void WhenIClickOnLearnMoreAboutUs()
        {
            informationaboutTheWebsite.ClickMoreAboutUs();
        }
        
        [Then(@"i should be able to see information about the website")]
        public void ThenIShouldBeAbleToSeeInformationAboutTheWebsite()
        {
            
            Assert.IsTrue(informationaboutTheWebsite.AboutusIsDisplayed());
        }
    }
}
