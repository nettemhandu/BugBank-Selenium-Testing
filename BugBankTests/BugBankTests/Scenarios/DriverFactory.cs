using System;
using System.Collections.Generic;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Steps
{
    public class DriverFactory
    {
        public static IWebDriver? Driver { get; private set; }

        [BeforeSuite]
        public void Setup()
        {
            var options = new ChromeOptions();

            // Enable automatic translation from Portuguese to English
            options.AddUserProfilePreference("translate_whitelists", new Dictionary<string, object> { { "pt", "en" } });
            options.AddUserProfilePreference("translate", new Dictionary<string, object> { { "enabled", true } });

            options.AddArgument("start-maximized");

            Driver = new ChromeDriver(options);

            // Optional: implicit wait (can adjust)
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [AfterSuite]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();  // closes all windows and safely ends driver
                Driver = null;
            }
        }
    }
}
