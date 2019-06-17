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
    public class HomePageBannerPage
    {
        public HomePageBannerPage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }


        [FindsBy(How = How.ClassName, Using = "banner-overlay")]
        private IWebElement banneroverlay { get; set; }

        public bool bannerIsDisplayed()
        {

            {
                return banneroverlay.Displayed;
            }








        }

    }
}
   

