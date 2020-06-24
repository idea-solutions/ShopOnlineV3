using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork;
using WebApi.Models.Dao;
using WebApi.Models.ModelView;

namespace WebApi.Models.FactoryModule
{
    public class Container : IContainer
    {
        
        private IFactory<CategoryMv> _categoryFactory;
        private IFactory<ProductMv> _productFactory;
        private IFactory<TypeProductMv> _typeProductFactory;
       

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        

        public Container(IUnitOfWork unitOfWork ,IMapper mapper){
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public IFactory<CategoryMv> CategoryFactory
        {
            get
            {
                return _categoryFactory??= new CategoryDao(_unitOfWork, _mapper);
            }
        }

        public IFactory<ProductMv> ProductFactory
        {
            get
            {
                return _productFactory ??= new ProductDao(_unitOfWork, _mapper);
            }
        }

        public IFactory<TypeProductMv> TypeProductFactory
        {
            get
            {
                return _typeProductFactory??= new TypeProductDao(_unitOfWork,_mapper);
            }
        }

 
    }
}
