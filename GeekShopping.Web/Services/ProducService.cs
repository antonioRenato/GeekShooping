using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;

namespace GeekShopping.Web.Services
{
    public class ProducService : IProductService
    {
        public Task<ProductModel> CreateProduct(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> FindAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> FindProductById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> UpdateProduct(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
