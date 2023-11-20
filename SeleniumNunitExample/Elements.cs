using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitExample
{
    [TestFixture]
    internal class Elements:CoreCodes
    {
       
        [Test]
        public void TestCheckBox()
        {
            /* IWebElement elements = driver.FindElement(By.XPath("//h5[text()='Elements']//preceding::parent::div"));
             elements.Click();*/
            /* IWebElement cbMenu = driver.FindElement(By.XPath("//span(text()='Check Box')//parent::li"));
             cbMenu.Click();
             List<IWebElement> expandCollapse= driver.FindElements(By.ClassName("rct-icon__rct-icon-expand-open")).ToList();
             foreach(var item in expandCollapse)
             {
                 item.Click();
             }
             IWebElement commandscheckbox = driver.FindElement(By.XPath("//span[text()='Commands']"));
             commandscheckbox.Click();
             Assert.True(driver.FindElement(By.XPath("//input[@id,'commands']")).Selected); */
           
            IWebElement firstname = driver.FindElement(By.Id("firstName"));
            firstname.SendKeys("vyshnav");
            Thread.Sleep(1000);
            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("KC");
            Thread.Sleep(1000);
            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("email@123.com");
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", email);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//label[text()='Male']")).Click();
            Thread.Sleep(3000);
            IWebElement mobile = driver.FindElement(By.Id("userNumber"));
            mobile.SendKeys("723766792");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("dateOfBirthInput")).Click();
            Thread.Sleep(5000);
            IWebElement month = driver.FindElement(By.ClassName("react-datepicker__month-select"));
            SelectElement selectElement = new SelectElement(month);
            selectElement.SelectByIndex(5);
            Thread.Sleep(3000);
            IWebElement year = driver.FindElement(By.ClassName("react-datepicker__year-select"));
            SelectElement selectElementyear = new SelectElement(year);
            selectElementyear.SelectByIndex(25);
            Thread.Sleep(3000);
            IWebElement day = driver.FindElement(By.XPath("//div[text()='6']"));
            day.Click();
            Thread.Sleep(3000);
            IWebElement subjectField = driver.FindElement(By.Id("subjectsInput"));
            subjectField.SendKeys("maths");
            subjectField.SendKeys(Keys.Enter);
            subjectField.SendKeys("chemistry");
            subjectField.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement hobbies = driver.FindElement(By.XPath("//label[text()='Sports']"));
            hobbies.Click();
            Thread.Sleep(3000);
            IWebElement hobbies1 = driver.FindElement(By.XPath("//label[text()='Music']"));
            hobbies1.Click();
            IWebElement image=driver.FindElement(By.Id("uploadPicture"));
            image.SendKeys(@"C:\\Users\\Administrator\\Pictures\\bloom-blooming-blossom-462118.jpg");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("currentAddress")).SendKeys("vengad koothparamba kannur ");
            Thread.Sleep(3000);
            IWebElement city = driver.FindElement(By.Id("state"));

            SelectElement citySelect = new SelectElement(city);
            citySelect.SelectByText("Uttar Pradesh");
            /*  driver.FindElement(By.Id("city"));
              driver.FindElement(By.XPath("//div[text()='Agra']")).Click();
  */


        }
        [Ignore("test changed")]
        [Test]
        public void WindowTest()
        {
            driver.Url = "https://demoqa.com/browser-windows";
            IWebElement clickElement = driver.FindElement(By.Id("tabButton"));

            for(var i=0;i<3;i++)
            {
                Console.WriteLine("current window handle"+driver.CurrentWindowHandle);
                clickElement.Click();
                Thread.Sleep(3000);
            }
            
        }
    }
}
