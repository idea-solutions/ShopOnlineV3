using System;
using System.Collections.Generic;
namespace WebAdmin.Models.ModelViews

{
    public class CategoryMv
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CategoryParent { get; set; }
        public Guid SubCategoryId { get; set; }
        public List<ProductMv> Products { get; set; }
    }
}