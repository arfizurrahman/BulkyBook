﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository ApplicationUser { get; }
        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IOrderHeaderRepository OrderHeader { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
