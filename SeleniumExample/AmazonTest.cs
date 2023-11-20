using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExample
{
    internal class AmazonTest
    {

        IWebDriver? driver;
        public void InitializeChromedriver()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.FullScreen();
        }
        public void InitializeEdgedriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.FullScreen();
        }
        public void TitleTest()
        {
            Thread.Sleep(1000);
            Console.WriteLine("title: " + driver.Title);
            Console.WriteLine("title length" + driver.Title.Length);
            Assert.AreEqual(driver.Title, "Amazon.com. Spend less. Smile more.");

        }
      
        public void LogoClickTest()
        {
            driver.FindElement(By.Id("nav-logo-sprites")).Click();
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("logo click test pass");

        }
        public void ProductSearchTest()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobiles");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click() ;
            Assert.That(("Amazon.com : mobiles".Equals(driver.Title)) && (driver.Url.Contains("mobiles")));
            Console.WriteLine("passed");
            Thread.Sleep(3000);

        }
        public void ReloadHomePage()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            Thread.Sleep(3000);
        }
        public void TodaysDealTest()
        {
            IWebElement webElement = driver.FindElement(By.LinkText("Today's Deals"));
            if (webElement != null)
            {
                webElement.Click();
                Thread.Sleep(3000);
                /*  Assert.AreEqual("Amazon.com - Today's Deals", driver.Title);*/
                Assert.That(driver.FindElement(By.TagName("h1")).Text.Equals("Today's Deals"));
            }
            else
                throw new NoSuchElementException("Element not found test fail");
        }
        public void SignInAccountListTest()
        {
            IWebElement helloSignIn = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            if(helloSignIn != null)
            {
                
                IWebElement accounyAndList = driver.FindElement(By.XPath("//*[@id=\"nav-link-accountList\"]/span"));
                if (accounyAndList == null)
                    throw new NoSuchElementException("Hello , Account and list is not present");
                Assert.That(helloSignIn.Text.Equals("Hello, sign in"));
                Console.WriteLine("Hello sign in is present -pass");
                Assert.That(accounyAndList.Text.Equals("Account & Lists"));
                Console.WriteLine("Account & Lists is present -pass");


            }
            else
            {
                throw new NoSuchElementException("sign is not found");
            }
        }
        public void SearchAndFilterProductByBrand()
        {

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobile phones");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
           // IWebElement motoElement=driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div"));
            driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div")).Click();
            Thread.Sleep(3000);
            
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/input")).Selected);
            //Assert.True();
            Console.WriteLine("Test passed");
            Thread.Sleep(3000);
            //  driver.FindElement(By.ClassName("a-expander-prompt")).Click();
            driver.FindElement(By.XPath("//*[@id=\"p_89/Apple\"]/span/a/div/label/i")).Click();
                Thread.Sleep(3000);
       
            Thread.Sleep(3000);
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/Apple\"]/span/a/div/label/input")).Selected);
            Console.WriteLine("Test passed");

        }
        public void SortBySelectTest()
        {
         IWebElement webElement= driver.FindElement(By.ClassName("a-dropdown-link.a-active"));
            SelectElement selectElement = (SelectElement)webElement;
            selectElement.SelectByValue("1");
            Thread.Sleep(3000);
            Console.WriteLine(selectElement.SelectedOption);
        }
        public void Destruct()
        {
            driver.Close();
        }
    }
}
