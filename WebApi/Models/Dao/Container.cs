using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork;
using WebApi.Models.ModelView;

namespace WebApi.Models.Dao
{
    public class Container : IContainer
    {
        
        private IFactory<CategoryMv> _categoryFactory;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public Container(IUnitOfWork unitOfWork ,IMapper mapper)
        {
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
    }
}
