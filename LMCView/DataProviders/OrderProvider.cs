using LMC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMC.Web.DataProviders
{
    public class OrderProvider
    {
        public OrderProvider()
        {
        }

        private IEnumerable<Order> GetOrders { get; }
        private IEnumerable<Order> GetActiveOrders { get; }

        private Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
