using Newtonsoft.Json;

namespace Ecommerce.ProductService.Services
{
    public class BaseService
    {
        protected async Task<T> GetModel<T>(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            string data = await response.Content.ReadAsStringAsync();
            T model = JsonConvert.DeserializeObject<T>(data);
            return model;
        }
    }
}
