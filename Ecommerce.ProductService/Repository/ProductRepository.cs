
namespace Ecommerce.ProductService.Repository
{
    public class ProductRepository : IProductRepository
    {
        public string GetAsync(int id)
        {
            return $"Estore Product Id : {id}";
        }

        public string CreateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllAsync(Predicate<string> product)
        {
            throw new NotImplementedException();
        }

     
        public string UpdateAsync(string product)
        {
            throw new NotImplementedException();
        }
    }
}
