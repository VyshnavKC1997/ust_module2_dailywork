﻿using CaseStudy.PageObject;
using CaseStudy.TestData;
using CaseStudy.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.TestScript
{
    internal class NaptolTest : CoreCodes
    {
        [Test]
        [Order(0)]
      
        public void NaptolSearchText()
        {
            string currDir = Directory.GetParent(@"../../../").FullName;
            string fileName = currDir + "\\TestData\\BunnyCart.xlsx";
            List<ExelData> excelDatas = ExcelUtils.ReadExcelData(fileName);
            HomePage homePage = new HomePage(driver);
            foreach (var excelData in excelDatas)
            {
                try
                {
                    string titlebefore = driver.Title;
                    homePage.SerachForProduct(excelData.SearchText);
                    homePage.ClickOnSearch();
                  
                    Assert.That(driver.Url.Contains("eyewear"));
                    test = extent.CreateTest("Search Test - Pass");
                    test.Pass("Search eyewear success");
                    TakeScreenShot();

                }
                catch (AssertionException)
                {
                    test = extent.CreateTest("Search Test - Fail");
                    test.Fail("Search eyewear failed");
                   
                }
               
            }
        }
        [Test]
        [Order(1)]
        public void SelectEyeWearTest()
        {
            SearchPage searchPage = new SearchPage(driver); 
            searchPage.ClickOnEyeWear();
        }
        [Test]
        [Order(2)]
        public void AddToCartTest()
        {
            
            ProductPage productPage = new ProductPage(driver);
            productPage.SizeSelect();
            productPage.AddToCart();
            productPage.Closemodal();
            productPage.ViewCart();
        }
    }
}
