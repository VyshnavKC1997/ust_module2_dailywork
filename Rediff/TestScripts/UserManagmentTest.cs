using Rediff.PageObject;
using Rediff.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.TestScripts
{
    [TestFixture]
    internal class UserManagmentTest:CoreCodes
    {
        //Assert
        [Test]
        [Order(0)]
        [Category("Smoke Test")]
        public void CreateAccountLinkTest()
        {
            var homePage=new RediffHomePage(driver);
            homePage.ClickOnCreateAccount();
            Assert.That(driver.Url.Contains("reg"));
        }
        [Test]
        [Order(1)]
        [Category("Smoke Test")]
        public void SignInClickTest()
        {
            driver.Navigate().GoToUrl("https://www.rediff.com/");
            var homePage=new RediffHomePage(driver);
            homePage.ClickOnSignIn();
            Assert.That(driver.Url.Contains("login"));
        }
        [Test]
        [Order(2)]
        public void CreateAccountTest()
        {
            var homePage=new RediffHomePage(driver);
            driver.Navigate().GoToUrl("https://www.rediff.com/");
            CreateAccountPage  page=homePage.CreateAccount(driver);
            page.FullNameType("vyshnav K C");
            page.RedItMailType("vyshnav@123");
            page.AvailabilityButtonType();
            page.CreateAccountClick();
        }
        [Ignore("CHECKING")]
        [Test]
        [Order(3)]
        public void SignInTest()
        {
            var homePage = new RediffHomePage(driver);
            driver.Navigate().GoToUrl("https://www.rediff.com/");
            RediffSignInPage signInPage = homePage.SignInAccount();
            signInPage.TypeUserName("vyshnav");
            signInPage.TypePassword("Password");
            signInPage.ClickCheckBox();
            signInPage.ClickSignInButton();
        }
    }
}
