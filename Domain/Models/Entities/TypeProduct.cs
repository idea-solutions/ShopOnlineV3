using System;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class TypeProduct
    {
        public Guid Id { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
      
    }
}