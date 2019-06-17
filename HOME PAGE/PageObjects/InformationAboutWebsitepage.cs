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
    public class InformationAboutWebsitePage
    {
        public InformationAboutWebsitePage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a.add-p:nth-child(3)")]
        private IWebElement learnmoreaboutus { get; set; }

        public void ClickMoreAboutUs()
        {
            learnmoreaboutus.Click();

        }

        [FindsBy(How = How.CssSelector, Using = ".breadcrumb-area")]
        private IWebElement aboutus { get; set; }

        public bool AboutusIsDisplayed()
        {

            {
                return aboutus.Displayed;
            }

        }
    }
}

    

