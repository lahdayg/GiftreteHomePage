using HOME_PAGE.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HOME_PAGE.StepDefinition
{
    [Binding]
    public class SubCategoriesUndercategoriesSteps
    {
        Subcategoriespage SubCategoriesUndercategories;

        public SubCategoriesUndercategoriesSteps()
        {
            SubCategoriesUndercategories = new Subcategoriespage();
        }

        [Then(@"i should see subcategories under categories")]
        public void ThenIShouldSeeSubcategoriesUnderCategories()
        {
            
            Assert.IsTrue(SubCategoriesUndercategories.ManinmenuDisplayed(), "SubCategories not on mainmenu");
        }

    }
}
