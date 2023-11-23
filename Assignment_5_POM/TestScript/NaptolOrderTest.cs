using Assignment_5_POM.PageObject;
using Assignment_5_POM.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_POM.TestScript
{
    internal class NaptolOrderTest:CoreCodes
    {
        [Test]
        public void SearchProductTest()
        {
            var homePage = new NaaptolHomePage(driver);
            var eyewear=new SearchResultPage(driver);
            homePage.SearchTextInSearchBox("eyewear");
            homePage.SearchTextInput();
            eyewear.ClickEyeWearElement();
        }
    }
}
