using LMC.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMC.Common
{
    public class Order : IHasId<Guid>
    {
        public Guid Id { get; set; }
        public IEnumerable<OrderLine> Lines { get; set; }
        public string DealCodeApplied { get; set; }

        [NotMapped]
        public decimal SubTotal { get; }

        [NotMapped]
        public decimal DiscountFromDeal { get; }

        [NotMapped]
        public decimal Total { get; }
    }
}
