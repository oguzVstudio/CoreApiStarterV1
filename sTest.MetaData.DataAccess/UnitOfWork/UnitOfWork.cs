using sTest.MetaData.Core.Interfaces.Repositories;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.DataAccess.Data;
using sTest.MetaData.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private RefreshTokenRepository _refreshTokenRepository;
        private ApplicationUserRepository _applicationUserRepository;
        private OrderTableRepository _orderTableRepository;
        private SalesTableRepository _salesTableRepository;
        private SellerTableRepository _sellerTableRepository;
        private SellerTargetTableRepository _sellerTargetTableRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IRefreshTokenRepository RefreshTokens =>
            _refreshTokenRepository ??= new RefreshTokenRepository(_context);

        public IApplicationUserRepository ApplicationUsers =>
            _applicationUserRepository ??= new ApplicationUserRepository(_context);

        public IOrderTableRepository OrderTableRepository => _orderTableRepository ??= new OrderTableRepository(_context);

        public ISalesTableRepository SalesTableRepository => _salesTableRepository ??= new SalesTableRepository(_context);

        public ISellerTableRepository SellerTableRepository => _sellerTableRepository ??= new SellerTableRepository(_context);

        public ISellerTargetTableRepository SellerTargetTableRepository => _sellerTargetTableRepository ??= new SellerTargetTableRepository(_context);
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
