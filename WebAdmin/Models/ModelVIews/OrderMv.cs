
using System;
using System.Collections.Generic;

namespace WebAdmin.Models.ModelViews
{
    public class OrderMv
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int PayWays { get; set; }
        public double Amount { get; set; }
        public int StatusOrder { get; set; }

        public UserMv AppUser { get; set; }
        public List<OrderDetailMv> OrderDetails { get; set; }
    }
}