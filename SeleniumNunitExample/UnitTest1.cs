
namespace SeleniumNunitExample
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
      //  [SetUp]
        public void Setup()
        {
           
            driver.Url = "https://www.google.com/";
        }
        [Ignore("other test")]
        [Test]
        public void CheckForTitle()
        {
           
            string title=driver.Title;
            Assert.That(Equals(title, "Google"));
            

        }
        [Test] 
        [Ignore("other test")]
        public void Test2()
        {
            driver.FindElement(By.Id("APjFqb")).SendKeys("hello");
           // driver.FindElement(By.Id("APjFqb")).Click();
            Thread.Sleep(10000);
        }
      //  [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}