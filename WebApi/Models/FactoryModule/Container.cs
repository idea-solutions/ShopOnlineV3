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
using Microsoft.AspNetCore.Hosting;
namespace WebApi.Models.FactoryModule
{
    public class Container : IContainer
    {
        private IFactory<CategoryMv> _categoryFactory;
        private IFactory<ProductMv> _productFactory;
        private IFactory<TypeProductMv> _typeProductFactory;
        private IFactory<ImageMv> _ImageFactory;
        [Obsolete]
        private readonly IHostingEnvironment _hostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        [Obsolete]
        public Container(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostingEnvironment;
        }
        public IFactory<CategoryMv> CategoryFactory => _categoryFactory ??= new CategoryDao(_unitOfWork, _mapper);

        public IFactory<ProductMv> ProductFactory => _productFactory ??= new ProductDao(_unitOfWork, _mapper);

        public IFactory<TypeProductMv> TypeProductFactory => _typeProductFactory ??= new TypeProductDao(_unitOfWork, _mapper);

        [Obsolete]
        public IFactory<ImageMv> ImageFactory => _ImageFactory ??= new ImageProductDao(_unitOfWork, _mapper, _hostEnvironment);
    }
}
