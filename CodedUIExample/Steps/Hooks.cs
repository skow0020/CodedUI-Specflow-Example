using CodedUIExample;
using TechTalk.SpecFlow;

namespace CodedUIExample.Steps
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            UtilityMethods.Launch();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            UtilityMethods.Close();
        }
    }
}
