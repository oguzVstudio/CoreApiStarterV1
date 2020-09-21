using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Services.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RefreshTokenService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<RefreshToken> CreateRefreshTokenAsync(RefreshToken newRefreshToken)
        {
            await _unitOfWork
                .RefreshTokens
                .AddAsync(newRefreshToken);

            await _unitOfWork.CommitAsync();

            return newRefreshToken;
        }

        public async Task DeleteRefreshTokenAsync(RefreshToken refreshToken)
        {
            _unitOfWork
                .RefreshTokens
                .Remove(refreshToken);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<RefreshToken>> GetAllRefreshTokensAsycn()
        {
            return await _unitOfWork
                .RefreshTokens
                .GetAllAsync();
        }

        public async Task<RefreshToken> GetRefreshTokenByTokenAsync(string refreshToken)
        {
            return await _unitOfWork
                .RefreshTokens
                .GetRefreshTokenByTokenAsync(refreshToken);
        }

        public async Task UpdateRefreshTokenAsync(RefreshToken refreshTokenToBeUpdated)
        {
            _unitOfWork
                .RefreshTokens
                .Update(refreshTokenToBeUpdated);

            await _unitOfWork.CommitAsync();
        }
    }
}
