using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_flipcart
{
    internal class FlipCartTest:CoreCodes
    {
        DefaultWait<IWebDriver> defaultWait;
        public void DefaultWait()
        {
            defaultWait = new DefaultWait<IWebDriver>(driver);
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.Message = "no such element";
        }
        [Test]
        [Description("Testing for search bar")]
        [Order(0)]
        public void SearchBarTest()
        {
            // string="_30XB9F"
            DefaultWait();
            defaultWait.Until(d => d.FindElement(By.ClassName("_30XB9F"))).Click();
            IWebElement searchBar = defaultWait.Until(d => d.FindElement(By.XPath("//input[@title='Search for Products, Brands and More']")));
            searchBar.SendKeys("laptop");
            searchBar.SendKeys(Keys.Enter);
        }
        [Test]
        [Description("Testing for add to cart")]
        [Order(1)]
        public void AddToCartTest()
        {
            //DefaultWait();
            List<string> list = driver.WindowHandles.ToList();
            IWebElement a=driver.FindElement(By.XPath("//a[@class='_1fQZEK'][1]"));
            a.Click();
           
            driver.SwitchTo().Window(list[0]);


        }

    }
}
