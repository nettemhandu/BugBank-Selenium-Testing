using FluentAssertions;
using Gauge.Csharp.Lib.Attribute;
using OpenQA.Selenium;
using Steps;

namespace Pages
{
    public class LoginPage
    {
        private const string Url = "https://bugbank.netlify.app/?utm_source=chatgpt.com";
        private static readonly IWebDriver Driver = DriverFactory.Driver;

        private static IWebElement EnterEmail => Driver.FindElement(By.Name("email"));
        private static IWebElement EnterPassword => Driver.FindElement(By.Name("password"));

        private static IWebElement AccessButton => Driver.FindElement(By.Text("Access"));

        private static IWebElement RegisterButton => Driver.FindElement(By.Text("Register"));

        private static IWebElement EnterName => Driver.FindElement(By.Name("name"));

        private static IWebElement ConfirmPassword => Driver.FindElement(By.Name("passwordConfirmation"));

        private static IWebElement CreateAccWithBalance => Driver.FindElement(By.Id("toggleAddBalance"));

        public LoginPage Open()
        {
            Driver.Navigate().GoToUrl(Url);
            Driver.Title.Should().Be("BugBank | The bank with bugs and glitches, your way.");
            return this;
        }
    }
}