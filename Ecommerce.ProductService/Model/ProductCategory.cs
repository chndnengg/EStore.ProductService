using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ProductService.Model
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
    }
}
