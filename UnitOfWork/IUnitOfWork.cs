using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.Entities;

namespace UnitOfWork
{
   public interface IUnitOfWork
    {
        IRepository<AppRole> AppRoles { get; }
        IRepository<AppUser> AppUsers { get; }
        IRepository<Cart> Carts { get; }
        IRepository<Category> Categories { get; }
        IRepository<Image> Images { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderDetail> OrderDetails { get; }
        IRepository<Product> Products { get; }
        IRepository<TypeProduct> TypeProducts { get; }

        bool Commit();
    }
}
