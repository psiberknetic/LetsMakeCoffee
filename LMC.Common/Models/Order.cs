using LMC.Common.Models;
using System.Collections.Generic;

namespace LMC.Common
{
    public class Order : IHasId<int>
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public OrderStatus Status { get; set; }
        public IEnumerable<OrderLine> Lines { get; set; }
    }
}
