using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.PageObject
{
    internal class CreateAccountPage
    {
        IWebDriver _driver;
        public CreateAccountPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'namec3f8')][@maxlength='61']")]
        public IWebElement FullNameText { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'login')]")]
        public IWebElement RedItMailText { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'btnchkavailc')]")]
        public IWebElement AvailabilityButton { get; set; }

        [FindsBy(How = How.Id, Using = "Register")]
        public IWebElement CreateAccountButton { get; set; }
        public void FullNameType(string name)
        {
        FullNameText.SendKeys(name);
        }
        public void RedItMailType(string mailType)
        {
            RedItMailText.SendKeys(mailType);
        }
        public void AvailabilityButtonType()
        {
            AvailabilityButton.Click();
        }
        public void CreateAccountClick()
        {
            CreateAccountButton.Click();
        }
    }
    
}
