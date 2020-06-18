using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using UnitOfWork;
using WebApi.Models.ModelView;

namespace WebApi.Models.Dao
{
    public class ProductDao
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductDao(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ProductMv>> GetAllProduct()
        {
            var data = await _unitOfWork.Products.GetAll();
            return _mapper.Map<List<ProductMv>>(data.ToList());
        }


        public ProductMv GetProductById(in Guid id)
        {
            return _mapper.Map<ProductMv>(_unitOfWork.Products.GetById(id).Result);
        }

        public object CreateNewProduct(ProductMv product)
        {
            var data = _mapper.Map<Product>(product);
            data = _unitOfWork.Products.CreateNewAddReturnObject(data);
            return _unitOfWork.Commit() ? _mapper.Map<ProductMv>(data) : null;
        }

        public bool UpdateProduct(Guid id, ProductMv product)
        {
            var data = _unitOfWork.Products.GetById(id).Result;
            data.CategoryId = product.CategoryId;
            data.ModifiedBy = product.ModifiedBy;
            data.DateModified = product.DateModified;
            data.Detail = product.Detail;
            data.Price = product.Price;
            data.Status = product.Status;
            _unitOfWork.Products.Edit(data);
            return _unitOfWork.Commit();
        }
        public bool DeleteProduct(Guid id)
        {

            _unitOfWork.Products.Delete(id);
            return _unitOfWork.Commit();
        }
    }
}
