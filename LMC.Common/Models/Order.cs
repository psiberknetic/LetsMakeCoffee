using System.Collections.Generic;
using System.Linq;

namespace LMC.Common
{
    public class Order : IHasId<int>
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public OrderStatus Status { get; set; }
        public IEnumerable<OrderLine> Lines { get; set; }
        public Deal AppliedDeal { get; set; }
        public decimal SubTotal => Lines.Sum(l => l.Item.Price * l.Quantity);
        public decimal AmountSaved => 0.0m;
        public decimal Total => SubTotal;
    }
}
