using HOME_PAGE.PageObjects;
using HOME_PAGE.Utilities;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HOME_PAGE.StepDefinition
{
    [Binding]
    public class HomePageBannerSteps
    {
        HomePageBannerPage HomePageBanner;

        public HomePageBannerSteps()
        {
            HomePageBanner = new HomePageBannerPage();
        }
        [Given(@"I navigate to https://pprod\.giftrete\.com")]
        public void GivenINavigateToHttpsPprod_Giftrete_Com()
        {
            Hooks1.Driver.Navigate().GoToUrl("Https://pprod.giftrete.com");
            Hooks1.Driver.Manage().Window.Maximize();

        }

        
        [Then(@"i should see banner for product on homepage")]
        public void ThenIShouldSeeBannerForProductOnHomepage()
        {
            
            Assert.IsTrue(HomePageBanner.bannerIsDisplayed());
        }
    }
}
