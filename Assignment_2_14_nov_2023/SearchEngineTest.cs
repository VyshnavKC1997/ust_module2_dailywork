using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_14_nov_2023
{
    internal class SearchEngineTest
    {
        IWebDriver driver;
        public void ChromeInitializer()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.co.in/";
        }
        public void GoogleSearchTest()
        {
            Thread.Sleep(1000);
            driver.Navigate().Back();
        }
        public void YahooForwardTest()
        {
            Thread.Sleep(1000);
            driver.Navigate().Forward();
        }
        public void YahooSearchTest() 
        {

            driver.FindElement(By.Id("APjFqb")).SendKeys("yahoo.com");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("gNO89b")).Click();
            
        }
        public void DiwaliSearchTest()
        {
            driver.FindElement(By.Id("APjFqb")).SendKeys("Whats new for diwali 2023");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("gNO89b")).Click();
        }
        public void RefreshTest()
        {
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
        }   
        public void Close()
        {
            driver?.Close();
        }
       
    }
}
