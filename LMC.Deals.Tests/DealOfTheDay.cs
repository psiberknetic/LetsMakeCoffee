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
        [Then(@"I am returned only the DealOfTheDay deal")]
        public void ThenIAmReturnedOnlyTheDealOfTheDayDeal()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
