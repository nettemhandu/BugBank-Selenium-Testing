using System;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Steps
{
    public class DriverFactory
    {
        public static IWebDriver Driver {get; private set;}

        [BeforeSuite]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

        [AfterSuite]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}