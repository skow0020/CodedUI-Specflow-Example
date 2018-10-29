using CodedUIExample.Pages.PageObjectCommonClasses;
using Microsoft.VisualStudio.TestTools.UITesting;
using TechTalk.SpecFlow;

namespace CodedUIExample.Steps
{
    [Binding]
    public sealed class CalcSteps
    {
        PageObjectCommon CommonPage;

        public CalcSteps()
        {
            CommonPage = new PageObjectCommon();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(string result)
        {
            CommonPage.VerifyResultIs(result);
        }

        [Given(@"the calculator app is open")]
        public void GivenTheCalculatorAppIsOpen()
        {
            
        }

        [Given(@"I have entered (.*) into calculator")]
        public void GivenIHaveEnteredIntoCalculator(string value)
        {
            CommonPage.EnterValue(value);
        }

        [Given(@"I press plus")]
        public void GivenIPressPlus()
        {
            Mouse.Click(CommonPage.addButton);
        }

        [When(@"I press equal")]
        public void WhenIPressEqual()
        {
            Mouse.Click(CommonPage.equalsButton);
        }


    }
}
