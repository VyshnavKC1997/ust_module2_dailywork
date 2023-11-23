using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_POM.PageObject
{
    internal class SearchResultPage
    {
        IWebDriver driver;  
        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How =How.XPath,Using = "//a[@title='Rectangle Anti Glare Reading Glass for Men & Women - B1G1 (RG5)'][contains(text(),'Rectangle Anti Glare Reading Glass for Men & Women')]")]
        public IWebElement EyewearElement { get; set; }

        public void ClickEyeWearElement()
        {
            EyewearElement.Click();
        }
    }
}
