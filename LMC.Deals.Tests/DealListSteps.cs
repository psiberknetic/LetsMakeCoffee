using FluentAssertions;
using LMC.Common;
using LMC.Common.Interfaces;
using LMC.Web.Providers;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace LMC.Deals.Tests
{
    [Binding]
    public class DealListSteps
    {
        private IDealProvider provider;
        private IEnumerable<Deal> deals;
        private Deal deal;

        [Given(@"A deal list that contains deals")]
        [Given(@"A deal in the list with a code of TenPercentOff")]
        [Given(@"A list that does not contain a deal called ItsAllFree")]
        public void GivenADealListThatContainsDeals()
        {
            provider = new StaticDealProvider();
        }

        [When(@"I request all the deals")]
        public void WhenIRequestAllTheDeals()
        {
            deals = provider.GetDeals();
        }

        [Then(@"the list that is returned contains all the deals")]
        public void ThenTheListThatIsReturnedContainsAllTheDeals()
        {
            deals.Should().NotBeNull();
            deals.Should().NotBeEmpty();
        }

        [Then(@"I am returned only the TenPercentOff deal")]
        public void ThenIAmReturnedOnlyTheTenPercentOffDeal()
        {
            deal.Code.Should().Be("TenPercentOff");
        }

        [Then(@"null is returned")]
        public void ThenNullIsReturned()
        {
            deal.Should().BeNull();
        }

        [When(@"I request the deal by the code (.*)")]
        public void WhenIRequestTheDealByTheCode(string p0)
        {
            deal = provider.GetDealByCode(p0);
        }
    }
}
