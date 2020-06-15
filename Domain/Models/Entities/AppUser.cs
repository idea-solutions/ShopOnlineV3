using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        
        public string PortalCode { get; set; }
    }
}