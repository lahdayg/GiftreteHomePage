using HOME_PAGE.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_PAGE.PageObjects
{
    public class HomePageProductPage
    {
        public HomePageProductPage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".mb--60 > h3:nth-child(1)")]
        private IWebElement ourservices { get; set; }

        public void ClickOurServices()
        {
            ourservices.Click();

        }

        [FindsBy(How = How.CssSelector, Using = ".mb--60)")]
        private IWebElement OurServices { get; set; }

        public bool ourservicesIsDisplayed()
        {

            {
                return ourservices.Displayed;
            }





        }
    }
}


