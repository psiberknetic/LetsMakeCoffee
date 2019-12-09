namespace LMC.Common.Models
{
    public class OrderLine
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
    }
}
