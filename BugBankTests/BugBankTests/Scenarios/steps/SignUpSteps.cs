using Gauge.CSharp.Lib.Attribute;
using Pages;

namespace Steps
{
    public class SignUpSteps
    {
        private readonly LoginPage _loginPage = new LoginPage();

        [Step("Open BugBank Homepage")]
        public void OpenBugbankHomepage()
        {
            _loginPage.Open();
        }

        [Step("Click Register to sign up for new account")]
        public void ClickRegister()
        {
            _loginPage.ClickRegisterButton();
        }

        [Step("Enter Email <email>")]
        public void EnterEmail(string email)
        {
            _loginPage.EnterEmail(email);
        }

        [Step("Enter Name <name>")]
        public void EnterName(string name)
        {
            _loginPage.EnterName(name);
        }

        [Step("Enter Password <password>")]
        public void EnterPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [Step("Confirm Password <password>")]
        public void ConfirmPassword(string password)
        {
            _loginPage.ConfirmPassword(password);
        }

        [Step("Click Create Account with Balance")]
        public void ClickCreateAccountWithBalance()
        {
            _loginPage.ClickCreateAccWithBalance();
        }

        [Step("Click Sign Up")]
        public void ClickSignUp()
        {
            _loginPage.ClickSignUpButton();
        }
    }
}
