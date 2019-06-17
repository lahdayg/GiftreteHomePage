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
    public class Subcategoriespage
    {
        public Subcategoriespage()

        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = ".mainmenu")]
        private IWebElement Mainmenu{ get; set; }

        public bool ManinmenuDisplayed()
        {

            {
                return Mainmenu.Displayed;
            }






        }

    }
}


