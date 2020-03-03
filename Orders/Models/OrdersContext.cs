
using Microsoft.EntityFrameworkCore;

namespace Orders.Models
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options)
            : base(options)
        {
        }

        public DbSet<OrderStatus> OrderStatus { get; set; }
    }
}
