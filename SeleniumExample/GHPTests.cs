using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace SeleniumExample
{
    internal class GHPTests
    {
        IWebDriver? driver;
        public void InitializeChromedriver()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.FullScreen();
        }
        public void InitializeEdgedriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.google.com/";
        }
        public void TitleTest()
        {
            Thread.Sleep(1000);
            Console.WriteLine("title: "+driver.Title);
            Console.WriteLine("title length"+driver.Title.Length);
            Assert.AreEqual(driver.Title, "Google");
          
        }
        public void PageSourceTest()
        {
            Console.WriteLine("Page source"+driver.PageSource);
            Console.WriteLine("Page Source length"+driver.PageSource.Length);
            Assert.AreEqual(driver.PageSource.Length,driver.PageSource.Length);
            
        }
        public void pageUrlTest()
        {
            Console.WriteLine("page url"+driver.Url);
            Console.WriteLine("page url length"+driver.Url.Length);
            Assert.AreEqual("https://www.google.com/", driver.Url);
        }
        public void TextBoxTest()
        {
            IWebElement textBoxWebElement = driver.FindElement(By.Id("APjFqb"));
            textBoxWebElement.SendKeys("Hello google");
            Thread.Sleep(5000);
            string urlbefore = driver.Url;
            IWebElement googlesearchWebelement = driver.FindElement(By.ClassName("gNO89b"));
            googlesearchWebelement.Click();
            string urlAfter= driver.Url;    
            Assert.AreNotEqual(urlbefore, urlAfter);
            Thread.Sleep(3000);

        }
        public void GmailLinkTest()
        {
            driver.Navigate().Back();
            driver.FindElement(By.LinkText("Gmail")).Click();
            Thread.Sleep(3000);
            Assert.That(driver.Title.Contains("Gmail"));
            Assert.That(driver.Url.Contains("about"));
      
        }
        public void GmailLinkTest2()
        {
            driver.Navigate().Back();
            driver.FindElement(By.PartialLinkText("ma")).Click();
            Thread.Sleep(3000);
            Assert.That(driver.Title.Contains("Gmail"));
            Assert.That(driver.Url.Contains("about"));

        }
        public void Destruct()
        {
            driver.Close();
        }
    }
}
