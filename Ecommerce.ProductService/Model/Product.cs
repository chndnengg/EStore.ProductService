using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ProductService.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Details { get; set; }
    }
}
