// See https://aka.ms/new-console-template for more information

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExample;
/*
GHPTests gHPTests = new GHPTests();
gHPTests.InitializeChromedriver();
try
{
    gHPTests.TitleTest();
    Console.WriteLine("passed");
    gHPTests.PageSourceTest();
    Console.WriteLine("passed");
    gHPTests.pageUrlTest();
    Console.WriteLine("passed");
    gHPTests.TextBoxTest();
    Console.WriteLine("passed");
    gHPTests.GmailLinkTest();
    Console.WriteLine("passed");
    gHPTests.GmailLinkTest2();
    Console.WriteLine("passed");

}
catch (AssertionException)
{
    Console.WriteLine("FAIL");
}
gHPTests.Destruct();

gHPTests.InitializeEdgedriver();
try
{
    gHPTests.TitleTest();
    Console.WriteLine("passed");
    gHPTests.PageSourceTest();
    Console.WriteLine("passed");
    gHPTests.pageUrlTest();
    Console.WriteLine("passed");
    gHPTests.TextBoxTest();
    Console.WriteLine("passed");
    gHPTests.GmailLinkTest();
    Console.WriteLine("passed");
    gHPTests.GmailLinkTest2();
    Console.WriteLine("passed");

}
catch (AssertionException)
{
    Console.WriteLine("FAIL");
}
gHPTests.Destruct();*/

AmazonTest gHPTests = new AmazonTest();
gHPTests.InitializeChromedriver();
try
{
    /* gHPTests.TitleTest();
     Console.WriteLine("passed");
     gHPTests.LogoClickTest();
     gHPTests.ProductSearchTest();
     gHPTests.ReloadHomePage();
     gHPTests.TodaysDealTest();*/
    // gHPTests.SignInAccountListTest();
    gHPTests.SearchAndFilterProductByBrand();
    gHPTests.SortBySelectTest();

}
catch (AssertionException)
{
    Console.WriteLine("FAIL");
}
catch(NoSuchElementException ex)
{
    Console.WriteLine(ex.Message);
}
gHPTests.Destruct();
/*
gHPTests.InitializeEdgedriver();
try
{
    gHPTests.TitleTest();
    Console.WriteLine("passed");
   gHPTests.ProductSearchTest();

}
catch (AssertionException)
{
    Console.WriteLine("FAIL");
}
gHPTests.Destruct();*/