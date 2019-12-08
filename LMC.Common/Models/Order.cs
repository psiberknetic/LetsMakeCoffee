using System;

namespace LMC.Common
{
    public class Order : IHasId<Guid>
    {
        public Guid Id { get; set; }
    }
}
