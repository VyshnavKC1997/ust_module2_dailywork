using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.PageObject
{
    internal class RediffHomePage
    {
        IWebDriver driver;
        public RediffHomePage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange

        [FindsBy(How=How.LinkText,Using = "Create Account")]
        public IWebElement? CreateAccountLink { get; set; }
        [FindsBy(How=How.LinkText,Using = "Sign in")]
        public IWebElement? SignInLink { get; set; }

        //act
        public void ClickOnCreateAccount()
        {
            CreateAccountLink?.Click();
        }
        public void ClickOnSignIn()
        {
            SignInLink?.Click();
        }
        public CreateAccountPage CreateAccount(IWebDriver driver)
        {
            CreateAccountLink?.Click();
            return new CreateAccountPage(driver);
        }
        public RediffSignInPage SignInAccount()
        {
            SignInLink?.Click();
            return new RediffSignInPage(driver);
        }
    }
}
