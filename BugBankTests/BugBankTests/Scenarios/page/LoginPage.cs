using OpenQA.Selenium;
using Steps;

namespace Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage()
        {
            driver = DriverFactory.Driver!; // Use ! to tell compiler it's not null
        }

        // === SIMPLE METHODS ===
        
        public void Open()
        {
            driver.Navigate().GoToUrl("https://bugbank.netlify.app/");
            Thread.Sleep(3000);
        }

        public void ClickRegisterToSignUp()
        {
            // Click "Register" button to switch to registration form
            var registerButton = driver.FindElement(By.XPath("//button[text()='Register']"));
            registerButton.Click();
            Thread.Sleep(1000);
        }

        public void EnterEmail(string email)
        {
            // Wait for registration form to be active
            Thread.Sleep(500);
            var emailField = driver.FindElement(By.CssSelector("input[name='email']"));
            emailField.SendKeys(email);
        }

        public void EnterName(string name)
        {
            var nameField = driver.FindElement(By.CssSelector("input[name='name']"));
            nameField.SendKeys(name);
        }

        public void EnterPassword(string password)
        {
            var passwordField = driver.FindElement(By.CssSelector("input[name='password']"));
            passwordField.SendKeys(password);
        }

        public void ConfirmPassword(string password)
        {
            var confirmField = driver.FindElement(By.CssSelector("input[name='passwordConfirmation']"));
            confirmField.SendKeys(password);
        }

        public void ClickCreateAccWithBalance()
        {
            // Click the toggle switch
            var toggle = driver.FindElement(By.CssSelector("label.styles__Container-sc-1pngcbh-0"));
            toggle.Click();
            Thread.Sleep(300);
        }

        public void ClickCadastrarButton()
        {
            // The SUBMIT button on registration form says "Register" (translated)
            // Find the SECOND "Register" button (the one in the registration form)
            var allRegisterButtons = driver.FindElements(By.XPath("//button[text()='Register']"));
            
            if (allRegisterButtons.Count >= 2)
            {
                // Click the second Register button (index 1)
                allRegisterButtons[1].Click();
            }
            else
            {
                // Fallback: just click any Register button
                var registerButton = driver.FindElement(By.XPath("//button[text()='Register']"));
                registerButton.Click();
            }
            
            Thread.Sleep(2000);
        }

        // === LOGIN METHODS ===
        
        public void EnterLoginEmail(string email)
        {
            // Make sure we're on login form
            Thread.Sleep(500);
            var emailField = driver.FindElement(By.CssSelector("input[name='email']"));
            emailField.SendKeys(email);
        }

        public void EnterLoginPassword(string password)
        {
            var passwordField = driver.FindElement(By.CssSelector("input[name='password']"));
            passwordField.SendKeys(password);
        }

        public void ClickAccessButton()
        {
            var accessButton = driver.FindElement(By.XPath("//button[text()='Access']"));
            accessButton.Click();
            Thread.Sleep(2000);
        }
    }
}