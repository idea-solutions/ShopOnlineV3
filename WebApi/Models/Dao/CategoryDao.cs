using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;
using UnitOfWork;
using WebApi.Models.ModelView;

namespace WebApi.Models.Dao
{
    public class CategoryDao : IFactory<CategoryMv>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryDao(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public virtual async Task<List<CategoryMv>> GetAll()
        {
            var data = await _unitOfWork.Categories.GetAll();
            return _mapper.Map<List<CategoryMv>>(data.ToList());
        }

        public virtual  CategoryMv GetById(object id)
        {
            return _mapper.Map<CategoryMv>(_unitOfWork.Categories.GetById(id).Result);
        }

        public virtual CategoryMv CreateNew(CategoryMv data)
        {
            var category = _mapper.Map<Category>(data);
            category = _unitOfWork.Categories.CreateNewAddReturnObject(category);
            return _unitOfWork.Commit() ? _mapper.Map<CategoryMv>(category) : null;
        }

        public bool Update(object id, CategoryMv data)
        {
            var category = _unitOfWork.Categories.GetById(id).Result;
            category.Name = data.Name;
            category.CategoryParent = data.CategoryParent;
            category.SubCategoryId = data.SubCategoryId;
            return _unitOfWork.Commit();
        }

        public virtual bool Delete(object id)
        {
            _unitOfWork.Categories.Delete(id);
            return _unitOfWork.Commit();
        }
    }
}
