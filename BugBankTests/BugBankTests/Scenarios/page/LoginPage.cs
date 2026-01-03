using OpenQA.Selenium;
using Steps;
using System;

namespace Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage()
        {
            driver = DriverFactory.Driver!;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl("https://bugbank.netlify.app/");
            Thread.Sleep(3000);
        }

        public void ClickRegisterToSignUp()
        {
            // SIMPLE: Find button by index (Button 2 from your output)
            var buttons = driver.FindElements(By.TagName("button"));
            if (buttons.Count > 2)
            {
                buttons[2].Click(); // Button 2 says "Register"
            }
            Thread.Sleep(2000);
        }

        public void EnterEmail(string email)
        {
            // Input 2 from your debug output is the email field
            var inputs = driver.FindElements(By.TagName("input"));
            if (inputs.Count > 2)
            {
                inputs[2].Clear();
                inputs[2].SendKeys(email);
            }
            Thread.Sleep(500);
        }

        public void EnterName(string name)
        {
            // Input 3 is the name field
            var inputs = driver.FindElements(By.TagName("input"));
            if (inputs.Count > 3)
            {
                inputs[3].Clear();
                inputs[3].SendKeys(name);
            }
            Thread.Sleep(500);
        }

        public void EnterPassword(string password)
        {
            // Input 4 is password field
            var inputs = driver.FindElements(By.TagName("input"));
            if (inputs.Count > 4)
            {
                inputs[4].Clear();
                inputs[4].SendKeys(password);
            }
            Thread.Sleep(500);
        }

        public void ConfirmPassword(string password)
        {
            // Input 5 is password confirmation
            var inputs = driver.FindElements(By.TagName("input"));
            if (inputs.Count > 5)
            {
                inputs[5].Clear();
                inputs[5].SendKeys(password);
            }
            Thread.Sleep(500);
        }

        public void ClickCreateAccWithBalance()
        {
            var toggle = driver.FindElement(By.CssSelector("label.styles__Container-sc-1pngcbh-0"));
            toggle.Click();
            Thread.Sleep(500);
        }

        public void ClickRegisterToCreateAccount()
        {
            // Button 5 is the second "Register" button (submit)
            var buttons = driver.FindElements(By.TagName("button"));
            if (buttons.Count > 5)
            {
                buttons[5].Click(); // Button 5 says "Register" (second one)
            }
            Thread.Sleep(2000);
        }

        // Login methods
        public void EnterLoginEmail(string email)
        {
            // Input 0 is the login email field
            var inputs = driver.FindElements(By.TagName("input"));
            if (inputs.Count > 0)
            {
                inputs[0].Clear();
                inputs[0].SendKeys(email);
            }
            Thread.Sleep(500);
        }

        public void EnterLoginPassword(string password)
        {
            // Input 1 is the login password field
            var inputs = driver.FindElements(By.TagName("input"));
            if (inputs.Count > 1)
            {
                inputs[1].Clear();
                inputs[1].SendKeys(password);
            }
            Thread.Sleep(500);
        }

        public void ClickAccessButton()
        {
            // Button 1 says "Access"
            var buttons = driver.FindElements(By.TagName("button"));
            if (buttons.Count > 1)
            {
                buttons[1].Click(); // Button 1 says "Access"
            }
            Thread.Sleep(2000);
        }
    }
}