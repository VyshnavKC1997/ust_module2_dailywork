using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitExample
{
    internal class LinkidinTest:CoreCodes
    {
        [Test]
        [Author("vyshnav")]
        [Description("checking for longin")]
        [Category("Load testing")]
        public void LoginTest()
        {
           
            WebDriverWait wau = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          
            IWebElement emailInput = wau.Until(ExpectedConditions.ElementIsVisible(By.Id("session_key")));
            IWebElement password = wau.Until(x => x.FindElement(By.Id("session_password")));

            emailInput.SendKeys("abc@hsdyh.com");
            password.SendKeys("asdasd");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
        }
        [Test]
        [Author("vyshnav")]
        [Description("checking for login")]
        [Category("smoke testing")]
        public void LoginTest1()
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
           /* WebDriverWait wau = new WebDriverWait(driver, TimeSpan.FromSeconds(10));*/
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.Message = "no such element";

            IWebElement emailInput = defaultWait.Until(d=>d.FindElement(By.Id("session_key")));
            IWebElement password =defaultWait.Until(x => x.FindElement(By.Id("session_password")));

            emailInput.SendKeys("abc@hsdyh.com");
            password.SendKeys("asdasd");
           /* driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);*/
        }
        [Test]
        [Author("vyshnav")]
        [Description("invalid credential")]
        [Category("regresssion testin")]
        /* [TestCase("zxc@2443","2354233653456")]
         [TestCase("qeqew@2443", "2354233653456")]
         [TestCase("qwe@2443", "2354233653456")]
         [TestCase("asdasc@2443", "2354233653456")]*/
        [TestCaseSource(nameof(InvalidLoginData))]
        public void LoginTest2(string a,string b)
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.Message = "no such element";

            IWebElement emailInput = defaultWait.Until(d => d.FindElement(By.Id("session_key")));
            IWebElement password = defaultWait.Until(x => x.FindElement(By.Id("session_password")));

            emailInput.SendKeys(a);
            password.SendKeys(b);
            Thread.Sleep(2000);
            ClearForm(emailInput, password);
            Thread.Sleep(2000);
       /*     emailInput.SendKeys(a);
            password.SendKeys(b);
            Thread.Sleep(2000);
            ClearForm(emailInput, password);
            Thread.Sleep(2000);
            emailInput.SendKeys(a);
            password.SendKeys(b);
            ClearForm(emailInput, password);*/
           
        }
        void ClearForm(IWebElement element,IWebElement element1)
        {
            element.Clear();
            element1.Clear();
        }
        static object[] InvalidLoginData()
        {
            return new object[]
            {
                new object[] {"sadhgghsd","3632hggsdahghsdagh6724367"},
                new object[] {"sa34223423gghsd","36326722344232344324367"},
                new object[] {"skkasdkjashkjasdashsd","363ghadshgsd26724367"},
                new object[] {"sadhgghsdakjsjhasdghghasdhghgd","3632ghadghahsd6724367"},
                new object[] {"sadtawewsqqxdshgghsd","363aljksdjhasdh26724367"},

            };
        }

    }
}
