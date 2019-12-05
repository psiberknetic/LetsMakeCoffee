using System;
using System.Collections.Generic;
using System.Text;

namespace LMC.Common
{
    public class Deal
    {
        public string Code { get; }
        public string Description { get; set; }
        public DealType Type { get; set; }
        public decimal Value { get; set; }
        public decimal MinimumOrder { get; set; }
    }
}
