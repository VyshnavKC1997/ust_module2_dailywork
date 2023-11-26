using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.PageObject
{
    internal class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How =How.XPath,Using = "//a[@title='Rectangle Anti Glare Reading Glass for Men & Women - B1G1 (RG5)'][contains(text(),'Rectangle Anti Glare Reading Glass for Men & Women')]")]
        public IWebElement Eyewear { get; set; }

        public void ClickOnEyeWear()
        {
            Actions actions = new Actions(driver);
            Action performActions = () => actions.MoveToElement(Eyewear).Build().Perform();
            performActions.Invoke();
            Eyewear.Click();
            List<string> list = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(list[1]);
        }
    }
}
