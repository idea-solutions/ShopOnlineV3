
using System;
using System.Collections.Generic;
using WebAdmin.Models.Enum;

namespace WebAdmin.Models.ModelView
{
    public class CategoryMv
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TypeCategories CategoryParent { get; set; }
        public Guid SubCategoryId { get; set; }
        public List<ProductMv> Products { get; set; }
        
      
    }
}