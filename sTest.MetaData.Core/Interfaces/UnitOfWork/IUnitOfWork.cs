using sTest.MetaData.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRefreshTokenRepository RefreshTokens { get; }
        IApplicationUserRepository ApplicationUsers { get; }
        IOrderTableRepository OrderTableRepository { get; }
        ISalesTableRepository SalesTableRepository { get; }
        ISellerTableRepository SellerTableRepository { get; }
        ISellerTargetTableRepository SellerTargetTableRepository { get; }

        Task<int> CommitAsync();
    }
}
