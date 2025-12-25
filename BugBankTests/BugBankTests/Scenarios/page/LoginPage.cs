using FluentAssertions;
using OpenQA.Selenium;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Steps;


namespace Pages
{
    public class LoginPage
    {
        private const string Url = "https://bugbank.netlify.app/?utm_source=chatgpt.com";
        private static readonly IWebDriver Driver = DriverFactory.Driver;

        private static IWebElement EnterEmail =>
        Driver.FindElement(By.Name("email"));
        private static IWebElement EnterPassword =>
        Driver.FindElement(By.Name("password"));

        private static IWebElement AccessButton =>
        Driver.FindElement(By.XPath("//button[normalize-space()='Access']"));

        private static IWebElement RegisterButton =>
        Driver.FindElement(By.XPath("//button[normalize-space()='Register']"));

        private static IWebElement EnterName =>
        Driver.FindElement(By.Name("name"));

        private static IWebElement ConfirmPassword =>
        Driver.FindElement(By.Name("passwordConfirmation"));

        private static IWebElement CreateAccWithBalance =>
        Driver.FindElement(By.Id("toggleAddBalance"));

        public void Open()
        {
            Driver!.Navigate().GoToUrl("https://bugbank.netlify.app/");
            WebDriverWait wait = new WebDriverWait(Driver!, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains("The bank with bugs and glitches"));

            // Now title assertion
            Driver!.Title.Should().Be("BugBank | The bank with bugs and glitches, your way.");
        }


        public void ClickAccessButton()
        {
            // Wait until button is clickable (good practice)
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AccessButton));

            // Click the button
            AccessButton.Click();
        }

        public void ClickCreateAccWithBalance()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CreateAccWithBalance));

            CreateAccWithBalance.Click();
        }

        public void ClickRegisterButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(RegisterButton));

            RegisterButton.Click();
        }
    }
}