using Buyer.Models;
using System.Data.Entity;

namespace Buyer.Contexts
{
    class OrderContext : DbContext
    {
        public OrderContext() : base("DefaultConnection")
        { }
        public DbSet<Order> Orders { get; set; }
    }
}
