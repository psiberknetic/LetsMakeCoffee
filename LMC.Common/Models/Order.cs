using System.Collections.Generic;

namespace LMC.Common
{
    public class Order : IHasId<int>
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public OrderStatus Status { get; set; }
        public IEnumerable<OrderLine> Lines { get; set; }
        public Deal AppliedDeal { get; set; }
        public decimal SubTotal { get; }
        public decimal AmountSaved { get; }
        public decimal Total { get; }
    }
}
