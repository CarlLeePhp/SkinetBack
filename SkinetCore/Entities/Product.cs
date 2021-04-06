using System.ComponentModel.DataAnnotations;

namespace SkinetCore.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
