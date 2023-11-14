// See https://aka.ms/new-console-template for more information

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExample;

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
gHPTests.Destruct();