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
    public class Categoriespage
    {
        public Categoriespage()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".mainmenu")]
        private IWebElement MainMenu{ get; set; }

        public bool MainmenuIsDisplayed()
        {

            try
            {
                return MainMenu.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
    
}