// using Gauge.Csharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Pages;

namespace Steps
{
    public class SignUpSteps
    {
        private readonly LoginPage _loginPage = new LoginPage();

        [Step("Open Bugbank Homepage")]
        public void OpenBugBank() => _loginPage.Open();
    }
}