using LMC.Common;
using LMC.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LMC.MenuService.Providers
{
    public class StaticDealProvider : IDealProvider
    {
        IEnumerable<Deal> _deals = new[]{
            new Deal("TenPctOffOrder", 0.1m, DealType.PercentOff),
            new Deal("OneDollarOff", 1.0m, DealType.DollarsOff),
            new Deal("TwentyPctOffOrder", 0.2m, DealType.PercentOff)
        };

        public Deal GetDealByCode(string dealCode)
        {
            return null;
        }

        public IEnumerable<Deal> GetDeals()
        {
            return Enumerable.Empty<Deal>();
        }
    }
}
