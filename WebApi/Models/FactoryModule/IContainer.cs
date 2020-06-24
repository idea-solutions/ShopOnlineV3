
using System;
using WebApi.Models.ModelView;

namespace WebApi.Models.FactoryModule
{
    public interface IContainer
    {
        public IFactory<CategoryMv> CategoryFactory { get; }
        public IFactory<ProductMv> ProductFactory { get; }
        public IFactory<TypeProductMv> TypeProductFactory { get; }
        
    }
}
