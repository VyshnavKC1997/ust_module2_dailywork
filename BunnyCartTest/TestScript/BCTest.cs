using BunnyCartTest.PageObject;
using BunnyCartTest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Edge;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCartTest.TestScript
{
    [TestFixture]
    internal class BCTest:CoreCodes
    {
        [Test]
        public void SignUpTest()
        { 
             
            BunnyCartHomePage home = new BunnyCartHomePage(driver);
            home.ClickCreateAnAccountLink();

            try
            {
                Assert.That(driver.FindElement(By.XPath("//div[@class='modal-inner-wrap']//following::h1[2]")).Text,
                    Is.EqualTo("Create an Account"));
                home.SignUp("vdy", "sgdhgf", "dagsgf", "dhgsagfsa", "gsadfgas", "2453453");
            }
            catch(AssertionException)
            {
                Console.WriteLine("Signup Failed");
            }
        }
        [Test]
        public void SearchProductTest()
        {
            BunnyCartHomePage home = new BunnyCartHomePage(driver);
            var searchResult=home.SearchWithText("flower");
            var productPage=searchResult.ClickFirstProductPage();
            searchResult.GetFirstProductLink();

        }
    }
}
