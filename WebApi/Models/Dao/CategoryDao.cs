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
    public class CategoryDao
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryDao(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public List<CategoryMv> GetAllCate()
        {
            var data = _unitOfWork.Categories.GetAll();
            return _mapper.Map<List<CategoryMv>>(data.ToList());
        }


        public CategoryMv GetCateById(in Guid id)
        {
            return _mapper.Map<CategoryMv>(_unitOfWork.Categories.GetById(id));
        }

        public object CreateNewCate(CategoryMv category)
        {
            var data = _mapper.Map<Category>(category);
            data = _unitOfWork.Categories.CreateNewAddReturnObject(data);
            return _unitOfWork.Commit() ? _mapper.Map<CategoryMv>(data) : null;
        }

        public bool UpdateCate(Guid id, CategoryMv category)
        {
            var data = _unitOfWork.Categories.GetById(id);
            data.Name = category.Name;
            data.CategoryParent = category.CategoryParent;
            data.SubCategoryId = category.SubCategoryId;

            return _unitOfWork.Commit();
        }

        public bool DeleteCate(Guid id)
        {
            _unitOfWork.Categories.Delete(id);
            return _unitOfWork.Commit();
        }
    }
}
