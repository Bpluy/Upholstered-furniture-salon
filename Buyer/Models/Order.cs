using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Buyer.Models
{
    [Table("Orders")]
    class Order
    {
        [Key]
        public int ID { get; set; }
        public string BuyerName { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
    }
}

