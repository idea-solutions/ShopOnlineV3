using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Entities
{
    class ProductType
    {
        public int  Id { get; set; }    
        public int  ProductId { get; set; }
        public int TypeId { get; set; }

    }
}
