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
    internal class BunnyCartHomePage
    {
        IWebDriver driver;
        public BunnyCartHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "search")]
        [CacheLookup]
        public IWebElement SearchBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[text()='Create an Account']")]
        [CacheLookup]
        public IWebElement CreateAccuntLink { get; set; }
        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement FirstNameInput { get; set; }
        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement LastNameInput { get; set; }
        [FindsBy(How = How.Id, Using = "popup-email_address")]
        private IWebElement EmailInput { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.Id, Using = "password-confirmation")]
        private IWebElement PasswordConfirmationInput { get; set; }

        [FindsBy(How = How.Id, Using = "mobilenumber")]
        private IWebElement MobileNumberInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@title='Create an Account']")]
        private IWebElement SignUpButton { get; set; }

        public void ClickCreateAnAccountLink()
        {
            CreateAccuntLink.Click();
        }
        public void SignUp(string firstName, string lastName, string email, string password
            , string confirmPasword, string mobileNumber)
        {
            IWebElement modal = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until
                (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(
                    "(//div[@class='modal-inner-wrap'])[position()=2]")));
            FirstNameInput.SendKeys(firstName);
            LastNameInput.SendKeys(lastName);
            EmailInput.SendKeys(email);
            ScrollIntoView(driver, EmailInput);
            PasswordInput.SendKeys(password);

            PasswordConfirmationInput.SendKeys(confirmPasword);
            ScrollIntoView(driver, MobileNumberInput);
            MobileNumberInput.SendKeys(mobileNumber);
            SignUpButton.Click();

        }
        static void ScrollIntoView(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public SearchResultPage SearchWithText(string text)
        {
            if (text == null)
                throw new NoSuchElementException(nameof(text));
            SearchBox.SendKeys(text);
            SearchBox.SendKeys(Keys.Enter);
            return new SearchResultPage(driver);
        }


    }
}
