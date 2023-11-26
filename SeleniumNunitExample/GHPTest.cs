using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitExample
{
    [TestFixture]
    internal class GHPTest:CoreCodes
    {

        [Ignore("other test")]
        [Test]
        [Order(0)]
        public void CheckForTitle()
        {

            string title = driver.Title;
            Assert.That(Equals(title,"Google"));


        }
        
        [Test]
        [Order(1)]
        public void TextBoxTest()
        {

            string currDir = Directory.GetParent(@"../../../").FullName;
            string fileName = currDir + "\\InputData.xlsx";
            List<ExcelData> excelDatas =ExcelUtils.ReadExcelData(fileName);
            foreach (ExcelData data in excelDatas)
            {
                IWebElement textBoxWebElement = driver.FindElement(By.Id("APjFqb"));
                textBoxWebElement.SendKeys(data.SearchText);
                string urlbefore = driver.Url;
                IWebElement googlesearchWebelement = driver.FindElement(By.ClassName("gNO89b"));
                googlesearchWebelement.Click();
                string urlAfter = driver.Url;
               /* Assert.AreNotEqual(urlbefore, urlAfter);*/
                Thread.Sleep(3000);
            }


          
            Thread.Sleep(5000);
           

        }
        [Test]
        [Order(2)]
        [Ignore("other test")]
        public void AllLinkStatusTest()
        {
            List<IWebElement> allLinks=driver.FindElements(By.TagName("a")).ToList();
            foreach(var link in allLinks)
            { 
                string url=link.GetAttribute("href");
                if(url != null)
                {
                    bool isWorking = CheckLinkStatus(url);
                    if (isWorking)
                        Console.WriteLine(url + " is working");
                    else
                        Console.WriteLine(url + " is not working");
                }
                else
                    Console.WriteLine("url is empty");
            }
        }
      

    }
}
