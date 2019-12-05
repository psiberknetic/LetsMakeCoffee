using System;
using System.Collections.Generic;
using System.Text;

namespace LMC.Common.Interfaces
{
    public interface IDealProvider
    {
        IEnumerable<Deal> GetDeals();
        Deal GetDealByCode(string dealCode);
    }
}
