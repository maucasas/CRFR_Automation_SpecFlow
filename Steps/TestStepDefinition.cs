using MDM_Automation_SpecFlow.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MDM_Automation_SpecFlow.Steps
{
    [Binding]
    public sealed class TestStepDefinition
    {
        [When(@"the test user select start date")]
        public void WhenTheTestUserSelectStartDate()
        {
            TestModule PageModule = new TestModule();
            PageModule.SelectStartDate("2020/11/06");
        }

    }
}
