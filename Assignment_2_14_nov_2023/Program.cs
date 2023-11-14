// See https://aka.ms/new-console-template for more information
using Assignment_2_14_nov_2023;
using NUnit.Framework;

SearchEngineTest searchEngineTest = new SearchEngineTest();
searchEngineTest.ChromeInitializer();
try
{
    searchEngineTest.YahooSearchTest();
    Console.WriteLine("Yahoo search test success");
    searchEngineTest.GoogleSearchTest();
    searchEngineTest.YahooForwardTest();
    Console.WriteLine("Yahoo search test success");
    searchEngineTest.GoogleSearchTest();
    searchEngineTest.DiwaliSearchTest();
    Console.WriteLine("Diwali serach test successful");
    searchEngineTest.RefreshTest();
    Console.WriteLine("refresh test successfull");
}
catch (AssertionException)
{
    Console.WriteLine("test fail");
}
searchEngineTest.Close();