using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCartTest.PageObject
{
    internal class ProductPage
    {
        IWebDriver driver;  
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//h1[@class='page-title]")]
        private IWebElement ProductTitle { get; }
        [FindsBy(How = How.Id, Using = "product-addtocart-button")]
        private IWebElement AddToCartButton { get; }

        public string? GetProductTitleLabel()
        {
            return ProductTitle.Text;   
        }
   
    }

   
}
