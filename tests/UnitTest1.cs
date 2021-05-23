using ESPN_POM_Nunit.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace ESPN_POM_Nunit
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            //maximizing the window
            driver.Manage().Window.Maximize();

            //navidating to page
            driver.Navigate().GoToUrl("http://espn.com");

            //setting implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test1()
        {
            homePage HomeP = new homePage(driver);
            HomeP.saveHeadline();
            HomeP.screenshot();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}