using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Steps;

namespace Pages
{
    public class LoginPage
    {
        private const string Url = "https://bugbank.netlify.app/";
        private static readonly IWebDriver Driver = DriverFactory.Driver!;

        // Login form elements
        private static IWebElement EmailField => Driver.FindElement(By.Name("email"));
        private static IWebElement PasswordField => Driver.FindElement(By.Name("password"));
        private static IWebElement AccessButton => Driver.FindElement(By.XPath("//button[normalize-space()='Access']"));
        private static IWebElement RegisterButton => Driver.FindElement(By.XPath("//button[normalize-space()='Register']"));


        // Sign up form elements
        private static IWebElement NameField => Driver.FindElement(By.Name("name"));
        private static IWebElement ConfirmPasswordField => Driver.FindElement(By.Name("passwordConfirmation"));
        private static IWebElement CreateAccWithBalance => Driver.FindElement(By.Id("toggleAddBalance"));
        private static IWebElement SignUpButton => Driver.FindElement(By.XPath("//button[text()='Cadastrar']"));

        public void Open()
        {
            Driver.Navigate().GoToUrl(Url);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));

            // Wait until the page title contains "BugBank"
            wait.Until(d => d.Title.Contains("BugBank"));

            // Ensure the title matches English
            Driver.Title.Should().Be("BugBank | O banco com bugs e falhas do seu jeito");
        }

        public void EnterEmail(string email)
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void EnterName(string name)
        {
            NameField.Clear();
            NameField.SendKeys(name);
        }

        public void ConfirmPassword(string password)
        {
            ConfirmPasswordField.Clear();
            ConfirmPasswordField.SendKeys(password);
        }

        public void ClickAccessButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(AccessButton));
            AccessButton.Click();
        }

        public void ClickRegisterButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(RegisterButton));
            RegisterButton.Click();
        }

        public void ClickCreateAccWithBalance()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(CreateAccWithBalance));
            CreateAccWithBalance.Click();
        }

        public void ClickSignUp()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));

            var signUpButton = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                    By.XPath("//button[normalize-space()='Registrar']")
                )
            );

            // Scroll into view (VERY important for BugBank)
            ((IJavaScriptExecutor)Driver)
                .ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", signUpButton);

            signUpButton.Click();
        }

    }
}
