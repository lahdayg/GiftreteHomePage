using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace HOME_PAGE.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
        }

        //[AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
