using CodedUIExample.Pages.LoginPageClasses;
using CodedUIExample.Pages.PageObjectCommonClasses;
using System.Windows.Forms;
using TechTalk.SpecFlow;

namespace CodedUIExample.Steps
{
    [Binding]
    public class CoreSteps
    {
        LoginPage LoginPg;
        PageObjectCommon CommonPage;

        public CoreSteps()
        {
            LoginPg = new LoginPage();
            CommonPage = new PageObjectCommon();
        }

        [Given(@"I am logged in")]
        public void ILogInAsUser()
        {
            LoginPg.Login();
        }
    }
}
