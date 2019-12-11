using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using LMC.Common;
using LMC.Common.Interfaces;
using LMC.Data.Providers;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace LMC.Deals.Tests
{
    [Binding]
    class DealOfTheDay
    {
        [Given(@"It is Monday")]
        public bool GivenItIsMonday()
        {
            //ScenarioContext.Current.Pending();
            return true;
        }

        [When(@"I add the deal to the menu items")]
        public bool WhenIAddTheDealToTheMenuItems()
        {
            //ScenarioContext.Current.Pending();
            return true;
        }
        
        [Then(@"I apply the deal to the menu items")]
        public bool ThenIApplyTheDealToTheMenuItems()
        {
            //ScenarioContext.Current.Pending();
            return true;
        }

    }
}
