using HOME_PAGE.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HOME_PAGE.StepDefinition
{
    [Binding]
    public class HomePageThreeMainProductsSteps
    {
        HomePageProductPage HomePageThreeMainproducts;

        public HomePageThreeMainProductsSteps()
        {
            HomePageThreeMainproducts = new HomePageProductPage();
        }

        [When(@"i scroll down and click our services")]
        public void WhenIScrollDownAndClickOurServices()
        {
            HomePageThreeMainproducts.ClickOurServices();
        }
        
        [Then(@"i should be able to see information aboutmthe three main product")]
        public void ThenIShouldBeAbleToSeeInformationAboutmtheThreeMainProduct()
        {
            
            Assert.IsTrue(HomePageThreeMainproducts.ourservicesIsDisplayed());
        }
    }
}
