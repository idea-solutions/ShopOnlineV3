using System;
using System.Collections.Generic;

namespace WebAdmin.Models.ModelViews
{
    public class TypeProductMv
    {
        public Guid Id { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Guid ProductId { get; set; }
        public ProductMv Product { get; set; }
        public List<OrderDetailMv> OrderDetails { get; set; }
      
    }
}