using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Buyer.Models;

namespace Buyer.Contexts
{
    class FurnitureContext : DbContext
    {
        public FurnitureContext() : base("DefaultConnection")
        { }
        public DbSet<Furniture> Furnitures { get; set; }
    }
}
