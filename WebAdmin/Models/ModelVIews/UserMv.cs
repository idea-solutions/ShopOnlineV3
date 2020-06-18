using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace WebAdmin.Models.ModelViews

{
    public class UserMv 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string PortalCode { get; set; }

        public List<CartMv> Carts { get; set; }
        public List<OrderMv> Orders { get; set; }
    }
}