using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rediff.PageObject
{
    internal class RediffSignInPage
    {

        IWebDriver _driver;

        public RediffSignInPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "login1")]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordText { get; set; }
        [FindsBy(How = How.Name, Using = "remember")]
        public IWebElement RememberMeCheckBox { get; set; }
        [FindsBy(How = How.Name, Using = "proceed")]
        public IWebElement SignInButton { get; set; }

        public void TypeUserName(string username)
        {
            UserName.SendKeys(username);
        }
        public void TypePassword(string password)
        {
            PasswordText.SendKeys(password);
        }
        public void ClickCheckBox()
        {
            RememberMeCheckBox.Click();
        }
        public void ClickSignInButton()
        {
            SignInButton.Click();
        }
        
       }
}
