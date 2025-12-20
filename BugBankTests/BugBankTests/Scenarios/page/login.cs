using FluentAssertions;
using OpenQA.Selenium;
using Steps;

namespace Pages
{
    public class LoginPage
    {
        private const string URL = "https://bugbank.netlify.app/?utm_source=chatgpt.com";
        private static readonly IWebDriver Driver = DriverFactory.Driver;

        private static IWebElement EnterEmail => Driver.FindElement(By.Name("email"));
        private static IWebElement EnterPassword => Driver.FindElement(By.Name("password"));

        private static IWebElement

        private static IWebElement RegisterButton => Driver.FindElement(By.Text("Register"));
    }
}