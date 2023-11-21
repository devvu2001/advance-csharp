using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
