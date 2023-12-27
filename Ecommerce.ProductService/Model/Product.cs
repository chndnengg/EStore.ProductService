using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.ProductService.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int ProductCategoryId {  get; set; }
        public string Details { get; set; }
        public ProductCategory Category { get; set; }
    }
}
