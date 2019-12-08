using LMC.Common;
using Microsoft.EntityFrameworkCore;

namespace LMC.Data.Orders.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
    }
}
