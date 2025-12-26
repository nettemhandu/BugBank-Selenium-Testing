using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Pages
{
    public class LoginPage
    {
        private const string Url = "https://bugbank.netlify.app/";
        private static readonly IWebDriver Driver = DriverFactory.Driver;

        // Locators

        private static IWebElement EmailInput =>
            Driver.FindElement(By.Name("email"));

        private static IWebElement PasswordInput =>
            Driver.FindElement(By.Name("password"));

        private static IWebElement NameInput =>
            Driver.FindElement(By.Name("name"));

        private static IWebElement ConfirmPasswordInput =>
            Driver.FindElement(By.Name("passwordConfirmation"));

        private static IWebElement AccessButton =>
            Driver.FindElement(By.XPath("//button[normalize-space()='Access']"));

        private static IWebElement OpenRegisterButton =>
            Driver.FindElement(By.XPath("//button[contains(text(),'Register')]"));

        private static IWebElement CreateAccountWithBalanceToggle =>
            Driver.FindElement(By.Id("toggleAddBalance"));

        private static IWebElement SubmitRegisterButton =>
            Driver.FindElement(By.XPath("//form//button[normalize-space()='Register']"));

        /* ========= Actions ========= */

        public void Open()
        {
            Driver.Navigate().GoToUrl(Url);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains("BugBank"));

            Driver.Title.Should()
                .Be("BugBank | The bank with bugs and glitches, your way.");
        }

        public void ClickAccessButton()
        {
            WaitUntilClickable(AccessButton);
            AccessButton.Click();
        }

        public void ClickRegisterButton()
        {
            WaitUntilClickable(OpenRegisterButton);
            OpenRegisterButton.Click();
        }

        public void EnterEmail(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
        }

        public void EnterName(string name)
        {
            NameInput.Clear();
            NameInput.SendKeys(name);
        }

        public void EnterPassword(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }

        public void ConfirmPassword(string password)
        {
            ConfirmPasswordInput.Clear();
            ConfirmPasswordInput.SendKeys(password);
        }

        public void ClickCreateAccountWithBalance()
        {
            WaitUntilClickable(CreateAccountWithBalanceToggle);
            CreateAccountWithBalanceToggle.Click();
        }

        public void SubmitRegistration()
        {
            WaitUntilClickable(SubmitRegisterButton);
            SubmitRegisterButton.Click();
        }

        /* ========= Helper ========= */

        private static void WaitUntilClickable(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
