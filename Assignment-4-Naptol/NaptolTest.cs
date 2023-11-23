using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumNunitExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Naptol
{
    internal class NaptolTest:CoreCodes
    {
        [Test]
        [Order(0)]
        public void NaptolSearchText()
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
            /* WebDriverWait wau = new WebDriverWait(driver, TimeSpan.FromSeconds(10));*/
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.Message = "no such element";
            IWebElement searchElement = defaultWait.Until(d => d.FindElement(By.Id("header_search_text")));
            Actions actions = new Actions(driver);
            Action performActions=()=>actions.SendKeys(searchElement,"eyewears").SendKeys(Keys.Enter).Build().Perform();
            performActions.Invoke();
            Thread.Sleep(4000);

        }
        [Test]
        [Order(1)]
        public void SelectEyeWearTest()
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
            /* WebDriverWait wau = new WebDriverWait(driver, TimeSpan.FromSeconds(10));*/
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.Message = "no such element";
            
            IWebElement eyeWear = defaultWait.Until(d => d.FindElement(By.XPath("//a[@title='Rectangle Anti Glare Reading Glass for Men & Women - B1G1 (RG5)'][contains(text(),'Rectangle Anti Glare Reading Glass for Men & Women')]")));
            Actions actions = new Actions(driver);
            Action performActions = () => actions.MoveToElement(eyeWear).Build().Perform();
            performActions.Invoke();
            eyeWear.Click();
            List<string> list = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(list[1]);
        }
        [Test]
        [Order(2)]
        public void AddToCartTest()
        {
            DefaultWait<IWebDriver> defaultWait = new DefaultWait<IWebDriver>(driver);
            WebDriverWait wau = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            defaultWait.Timeout = TimeSpan.FromSeconds(5);
            defaultWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.Message = "no such element";
           
            IWebElement eyeWear = defaultWait.Until(d => d.FindElement(By.XPath("//a[text()='Yellow-1.50']")));
            eyeWear.Click();
            IWebElement button = defaultWait.Until(d => d.FindElement(By.XPath("//span[text()='Click here to Buy']")));
            Actions actions = new Actions(driver);
            Action performActions = () => actions.MoveToElement(button).Build().Perform();
            performActions.Invoke();
            button.Click();
            IWebElement close = defaultWait.Until(d => d.FindElement(By.XPath("//a[@title='Close']")));
            close.Click();
            IWebElement cart = defaultWait.Until(d => d.FindElement(By.XPath("//span[@class='cartIcon']")));
            cart.Click();
            Thread.Sleep(3000);
        }
    }
}
