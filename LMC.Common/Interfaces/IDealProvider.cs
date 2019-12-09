using System.Collections.Generic;

namespace LMC.Common.Interfaces
{
    public interface IDealProvider
    {
        IEnumerable<Deal> GetDeals();
        Deal GetDealByCode(string dealCode);
    }
}
