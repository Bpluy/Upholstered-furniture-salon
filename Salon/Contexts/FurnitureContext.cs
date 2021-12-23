using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Salon.Models;

namespace Salon.Contexts
{
    class FurnitureContext : DbContext
    {
        public FurnitureContext() : base("DefaultConnection")
        { }
        public DbSet<Furnitures> Furniture { get; set; }
    }
}
