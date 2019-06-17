using HOME_PAGE.PageObjects;
using HOME_PAGE.Utilities;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HOME_PAGE.StepDefinition
{
    [Binding]
    public class CategoriesOnHomePageSteps
    {
        Categoriespage categoriesOnHomePage;
        public CategoriesOnHomePageSteps()
        {
            categoriesOnHomePage = new Categoriespage();
        }

        [Given(@"I navigate to http://qa(.*)\.giftrt\.com/home/")]
        public void GivenINavigateToHttpQa_Giftrt_ComHome(int p0)
        {
            Hooks1.Driver.Navigate().GoToUrl("Https://pprod.giftrete.com");
            Hooks1.Driver.Manage().Window.Maximize();

        }

        [Then(@"i should see categories on homepage")]
        public void ThenIShouldSeeCategoriesOnHomepage()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(categoriesOnHomePage.MainmenuIsDisplayed(), "Categories not on mainmenu");
        }

    }
}
