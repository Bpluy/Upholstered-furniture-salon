using Buyer.Models;
using System.Data.Entity;

namespace Buyer.Contexts
{
    class FurnitureContext : DbContext
    {
        public FurnitureContext() : base("DefaultConnection")
        { }
        public DbSet<Furniture> Furnitures { get; set; }
    }
}
