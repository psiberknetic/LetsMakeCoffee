using System;

namespace LMC.Common.Models
{
    public class OrderLine : IHasId<Guid>
    {
        public Guid Id { get; set; }
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
    }
}
