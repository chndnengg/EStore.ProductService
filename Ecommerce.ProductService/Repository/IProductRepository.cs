using Ecommerce.ProductService.Model;

namespace Ecommerce.ProductService.Repository
{
    public interface IProductRepository
    {
        string GetAsync(int id);
        List<string> GetAllAsync(Predicate<string> product);
        string CreateAsync(int id);
        string UpdateAsync(string product);
        string Delete(int id);
    }
}
