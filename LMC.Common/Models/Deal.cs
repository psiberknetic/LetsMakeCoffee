using System;

namespace LMC.Common
{
    public class Deal
    {
        public Deal(string code, decimal value, DealType type, decimal minimumOrder = 0.0m)
        {
            Code = code;
            Value = value;
            Type = type;
            MinimumOrder = minimumOrder;
        }

        public string Code { get; }
        public string Description { get; set; }
        public DealType Type { get; }
        public decimal Value { get; }
        public decimal MinimumOrder { get; }

        public DayOfWeek? ValidOnDay { get; set; }
    }
}
