using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using Domain.Models.Enum;
using UnitOfWork;
using WebApi.Models.FactoryModule;
using WebApi.Models.ModelView;

namespace WebApi.Models.Dao
{
    public class ProductDao : IFactory<ProductMv>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductDao(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<ProductMv>> GetAll()
        {
            var data = _mapper.Map<List<ProductMv>>(await _unitOfWork.Products.GetAll());
            return data.ToList();
        }
        public ProductMv GetById(object id)
        {
            return _mapper.Map<ProductMv>(_unitOfWork.Products.GetById(id).Result);
        }
        public ProductMv CreateNew(ProductMv data)
        {
            var product = _mapper.Map<Product>(data);
            product = _unitOfWork.Products.CreateNewAddReturnObject(product);
            return _unitOfWork.Commit() ? _mapper.Map<ProductMv>(product) : null;
        }
        public bool Update(object id, ProductMv data)
        {
            var product = _unitOfWork.Products.GetById(id).Result;
            product.CategoryId = data.CategoryId;
            product.ModifiedBy = data.ModifiedBy;
            product.DateModified = DateTime.Now;
            product.Detail = data.Detail;
            product.Price = data.Price;
            product.Name = data.Name;
            _unitOfWork.Products.Edit(product);
            return _unitOfWork.Commit();
        }

        public bool Disable(object id)
        {
            var product = _unitOfWork.Products.GetById(id).Result;
            if(product.Status ==1) product.Status = (int)Status.Lock;
            else product.Status = (int)Status.Active;
            return _unitOfWork.Commit();

        }
        public bool Delete(object id)
        {
            if (_unitOfWork.Products
                .GetAll().Result
                .Count(x => x.Images.Any(image => image.ProductId == (Guid)id) ||
                            x.TypeProducts.Any(x => x.ProductId == (Guid)id)) > 0) return false;
            _unitOfWork.TypeProducts.Delete(id);
            return _unitOfWork.Commit();
        }
    }
}
