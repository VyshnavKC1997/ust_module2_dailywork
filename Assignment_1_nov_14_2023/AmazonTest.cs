using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_nov_14_2023
{
    internal class AmazonTest
    {
        IWebDriver driver;
        public void ChromeInitializer()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.amazon.com/";
        }
        public void TitleCheckTest()
        {
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
        }
        public void UrlTest()
        {
            Assert.That(driver.Url.Contains(".com"));
        }
        public void TerminateProcess()
        {
            driver.Close();
        }
    }
}
