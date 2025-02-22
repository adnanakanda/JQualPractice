using Reqnroll;
using SeleniumKP1_2.Framework.Tests;

namespace SeleniumKP1_2.Framework
{
    internal class Hooks : BaseTest
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Setup();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TearDown();
        }
    }
}
