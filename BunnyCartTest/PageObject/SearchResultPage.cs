using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCartTest.PageObject
{
    internal class SearchResultPage
    {
        IWebDriver driver;
        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"amasty-shopby-product-list\"]/div[2]/ol/li[1]/div/div[1]/a")]
        private IWebElement FirstProductLink { get; }

        public string? GetFirstProductLink()
        {
            return FirstProductLink.Text;
        }
        public ProductPage ClickFirstProductPage()
        {
            FirstProductLink.Click();
            return new ProductPage(driver);
        }
    }
}
