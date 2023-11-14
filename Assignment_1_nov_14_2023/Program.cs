// See https://aka.ms/new-console-template for more information
using Assignment_1_nov_14_2023;
using NUnit.Framework;

AmazonTest test = new AmazonTest();
test.ChromeInitializer();

try
{
    test.TitleCheckTest();
    Console.WriteLine("Test success");
    test.UrlTest();
    Console.WriteLine("test success");
}
catch (AssertionException)
{
    Console.WriteLine("Test fail");
}
test.TerminateProcess();