// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver=new ChromeDriver();
driver.Url = "https://www.google.com/";
Thread.Sleep(10000);
driver.Close();
