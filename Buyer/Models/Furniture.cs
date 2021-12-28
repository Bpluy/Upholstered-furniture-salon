using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Buyer.Models
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

