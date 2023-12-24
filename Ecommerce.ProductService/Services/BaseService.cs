using Newtonsoft.Json;

namespace Ecommerce.ProductService.Services
{
    public class BaseService
    {
        HttpClient client = new HttpClient();

        protected async Task<T> GetModel<T>(string url)
        {
            var response = await client.GetAsync(url);
            string data = await response.Content.ReadAsStringAsync();
            T model = JsonConvert.DeserializeObject<T>(data);
            return model;
        }
        protected async Task<T> CreateModel<T>(string url, T model)
        {
            var response = await client.PostAsJsonAsync<T>(url, model);
            return model;
        }
    }
}
