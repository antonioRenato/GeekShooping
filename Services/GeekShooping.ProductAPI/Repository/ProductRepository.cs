using AutoMapper;
using GeekShooping.ProductAPI.Data.ValueObjects;
using GeekShooping.ProductAPI.Model;
using GeekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ProductVO> Create(ProductVO product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();

            return _mapper.Map<List<ProductVO>>(products);
        }

        public Task<ProductVO> FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> Update(ProductVO product)
        {
            throw new NotImplementedException();
        }
    }
}
