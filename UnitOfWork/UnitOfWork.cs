using System;
using System.Collections.Generic;
using System.Text;
using Domain.EF;
using Domain.Models.Entities;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private WebOnlineDbContext _dbContext;

        private BaseRepository<AppRole> _AppRole;
        private BaseRepository<AppUser> _AppUser;
        private BaseRepository<Cart> _Cart;
        private BaseRepository<Category> _Category;
        private BaseRepository<Image> _Image;
        private BaseRepository<Product> _Product;
        private BaseRepository<TypeProduct> _TypeProduct;
        private BaseRepository<Order> _Order;
        private BaseRepository<OrderDetail> _OrderDetail;

        public  UnitOfWork(WebOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IRepository<AppRole> AppRoles
        {
            get
            {
                return _AppRole ??= new BaseRepository<AppRole>(_dbContext);
            }
        }

        public virtual IRepository<AppUser> AppUsers
        {
            get
            {
                return _AppUser ??= new BaseRepository<AppUser>(_dbContext);
            }
        }

        public virtual IRepository<Cart> Carts
        {
            get
            {
                return _Cart ??= new BaseRepository<Cart>(_dbContext);
            }
        }
        public virtual IRepository<Category> Categories
        {
            get
            {
                return _Category ??= new BaseRepository<Category>(_dbContext);
            }
        }
        public virtual IRepository<Image> Images
        {
            get
            {
                return _Image ??= new BaseRepository<Image>(_dbContext);
            }
        }
        public virtual IRepository<Order> Orders
        {
            get
            {
                return _Order ??= new BaseRepository<Order>(_dbContext);
            }
        }
        public virtual IRepository<OrderDetail> OrderDetails
        {
            get
            {
                return _OrderDetail ??= new BaseRepository<OrderDetail>(_dbContext);
            }
        }
        public virtual IRepository<Product> Products
        {
            get
            {
                return _Product ??= new BaseRepository<Product>(_dbContext);
            }
        }
        public virtual IRepository<TypeProduct> TypeProducts
        {
            get
            {
                return _TypeProduct ??= new BaseRepository<TypeProduct>(_dbContext);
            }
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
