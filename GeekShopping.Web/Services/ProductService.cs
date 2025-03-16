using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public const string apiKey = "api/v1/product";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _httpClient.PostAsJson(apiKey,model);
            
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProductModel>();
            }

            throw new Exception("Something went wrong when tryed to call API");
        }

        public async Task<bool> DeleteProduct(long id)
        {
            var response = await _httpClient.DeleteAsync($"{apiKey}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<bool>();
            }

            throw new Exception("Something went wrong when tryed to call API");
        }

        public async Task<IEnumerable<ProductModel>> FindAllProduct()
        {
            var response = await _httpClient.GetAsync(apiKey);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _httpClient.GetAsync($"{apiKey}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _httpClient.PutAsJson(apiKey, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProductModel>();
            }

            throw new Exception("Something went wrong when tryed to call API");
        }
    }
}
