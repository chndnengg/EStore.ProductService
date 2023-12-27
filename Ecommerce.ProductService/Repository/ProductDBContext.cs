using Ecommerce.ProductService.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Repository
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options):base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
