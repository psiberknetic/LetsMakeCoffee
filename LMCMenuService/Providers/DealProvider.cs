using LMC.Common;
using LMC.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LMC.MenuService.Providers
{
    public class DealProvider : IDealProvider
    {
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
