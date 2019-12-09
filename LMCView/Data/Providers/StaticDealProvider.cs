using LMC.Common;
using LMC.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LMC.Data.Providers
{
    public class StaticDealProvider : IDealProvider
    {
        private IEnumerable<Deal> _deals = new[]{
            new Deal("TenPercentOff", 0.1m, DealType.PercentOff),
            new Deal("OneDollarOff", 1.0m, DealType.DollarsOff),
            new Deal("TwentyPercentOff", 0.2m, DealType.PercentOff)
        };

        public Deal GetDealByCode(string dealCode)
        {
            return _deals.FirstOrDefault(d => d.Code == dealCode);
        }

        public IEnumerable<Deal> GetDeals()
        {
            return _deals;
        }
    }
}
