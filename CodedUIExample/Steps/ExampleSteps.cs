using CodedUIExample.Pages.PageObjectCommonClasses;
using System.Windows.Forms;
using TechTalk.SpecFlow;

namespace CodedUIExample.Steps
{
    [Binding]
    public sealed class ExampleSteps
    {
        PageObjectCommon CommonPage;

        public ExampleSteps()
        {
            CommonPage = new PageObjectCommon();
        }

        [When(@"I do something cool with '(.*)'")]
        public void WhenIDoSomethingCoolWith(string p0)
        {
            CommonPage.DoSomethingCoolWith(p0);
        }

        [Then(@"something exciting is verified")]
        public void ThenSomethingExcitingIsVerified()
        {
            CommonPage.VerifySomethingExciting();
        }
    }
}
