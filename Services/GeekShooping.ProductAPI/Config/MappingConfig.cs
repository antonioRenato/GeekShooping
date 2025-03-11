using AutoMapper;
using GeekShooping.ProductAPI.Data.ValueObjects;
using GeekShooping.ProductAPI.Model;

namespace GeekShooping.ProductAPI.Config
{
    public class MappingConfig
    {
        private readonly IMapper _mapper;

        public MappingConfig(IMapper mapper)
        {
            _mapper = mapper;
        }

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig =  new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });

            return mappingConfig;
        }
    }
}
