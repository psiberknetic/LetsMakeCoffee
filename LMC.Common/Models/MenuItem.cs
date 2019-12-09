using System;

namespace LMC.Common
{
    public class MenuItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MenuCategory Category { get; set; }
        public decimal Price { get; set; }
    }
}
