using System;
using System.Collections.Generic;
using System.Text;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            Company = new CompanyRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetails = new OrderDetailsRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public IApplicationUserRepository ApplicationUser { get; }
        public ICategoryRepository Category { get; }
        public ICompanyRepository Company { get; }
        public ICoverTypeRepository CoverType { get; }
        public IProductRepository Product { get; }
        public IShoppingCartRepository ShoppingCart { get; }
        public IOrderHeaderRepository OrderHeader { get; }
        public IOrderDetailsRepository OrderDetails { get; }
        public ISP_Call SP_Call { get; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
