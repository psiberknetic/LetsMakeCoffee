using LMC.Common;
using LMC.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMC.MenuService.Providers
{
    public class CSVDealProvider : IDealProvider
    {
        public Deal GetDealByCode(string dealCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Deal> GetDeals()
        {
            throw new NotImplementedException();
        }
    }
}
