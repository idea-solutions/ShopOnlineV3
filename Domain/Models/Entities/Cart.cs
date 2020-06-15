using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Entities
{
   public class Cart
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int  ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
