using System;

namespace LMC.Common.Models
{
    public class MenuItem : IHasId<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Guid Id { get; set; }
    }
}
