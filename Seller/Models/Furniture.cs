using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller.Models
{
    [Table("Furniture")]
    class Furniture
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool isAvailable { get; set; }
        public byte[] Picture { get; set; }
    }
}
