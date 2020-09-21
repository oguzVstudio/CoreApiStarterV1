using Microsoft.EntityFrameworkCore;
using sTest.MetaData.Core.Interfaces.Repositories;
using sTest.MetaData.Core.Models;
using sTest.MetaData.DataAccess.Data;
using sTest.MetaData.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.DataAccess.Repositories
{
    public class RefreshTokenRepository : Repository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(ApplicationDbContext context) : base(context)
        {
        }

        private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;

        public async Task<RefreshToken> GetRefreshTokenByTokenAsync(string refreshToken)
        {
            return await ApplicationDbContext
                .RefreshTokens
                .Include(u => u.User)
                .SingleOrDefaultAsync(u => u.Token == refreshToken);
        }
    }
}
