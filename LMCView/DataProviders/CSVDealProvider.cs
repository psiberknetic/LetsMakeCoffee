using LMC.Common;
using LMC.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace LMC.Web.Providers
{
    public class CsvDealProvider : IDealProvider
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
