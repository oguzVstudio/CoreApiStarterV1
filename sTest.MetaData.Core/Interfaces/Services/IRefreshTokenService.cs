using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.Services
{
    public interface IRefreshTokenService
    {
        Task<RefreshToken> GetRefreshTokenByTokenAsync(string refreshToken);
        Task<IEnumerable<RefreshToken>> GetAllRefreshTokensAsycn();
        Task<RefreshToken> CreateRefreshTokenAsync(RefreshToken newRefreshToken);
        Task UpdateRefreshTokenAsync(RefreshToken refreshTokenToBeUpdated);
        Task DeleteRefreshTokenAsync(RefreshToken refreshToken);
    }
}
