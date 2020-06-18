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
    public class TypeProductDao
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TypeProductDao(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<List<TypeProduct>> GetAllTypeProduct()
        {
            var data = await _unitOfWork.TypeProducts.GetAll();
            return _mapper.Map<List<TypeProduct>>(data.ToList());
        }


        public TypeProduct GetTypeProductById(in Guid id)
        {
            return _mapper.Map<TypeProduct>(_unitOfWork.TypeProducts.GetById(id).Result);
        }

        public object CreateNewTypeProduct(TypeProductMv typeProduct)
        {
            var data = _mapper.Map<TypeProduct>(typeProduct);
            data = _unitOfWork.TypeProducts.CreateNewAddReturnObject(data);
            return _unitOfWork.Commit() ? _mapper.Map<TypeProductMv>(data) : null;
        }

        public bool UpdateTypeProduct(Guid id, TypeProductMv typeProduct)
        {
            var data = _unitOfWork.TypeProducts.GetById(id).Result;
            data.Color = typeProduct.Color;
            data.Color = typeProduct.Size;
                        return _unitOfWork.Commit();
        }

        public bool DeleteTypeProduct(Guid id)
        {
            if (_unitOfWork.Products
                .GetAll().Result
                .Count(x => x.Images.Any(image => image.ProductId == id) ||
                            x.TypeProducts.Any(x => x.ProductId == id)) > 0) return false;
            _unitOfWork.TypeProducts.Delete(id);
            return _unitOfWork.Commit();
        }
    }
}
