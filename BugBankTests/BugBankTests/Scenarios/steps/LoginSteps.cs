using Gauge.CSharp.Lib.Attribute;
using Pages;

namespace Steps
{
    public class LoginSteps
    {
        private readonly LoginPage _loginPage = new LoginPage();

        [Step("Enter Login Email <email>")]
        public void EnterLoginEmail(string email)
        {
            _loginPage.EnterLoginEmail(email);
        }

        [Step("Enter Login Password <password>")]
        public void EnterLoginPassword(string password)
        {
            _loginPage.EnterLoginPassword(password);
        }

        [Step("Click Access Button")]
        public void ClickAccessButton()
        {
            _loginPage.ClickAccessButton();
        }

        [Step("User should see dashboard")]
        public void UserShouldSeeDashboard()
        {
            Thread.Sleep(2000);
        }
    }
}