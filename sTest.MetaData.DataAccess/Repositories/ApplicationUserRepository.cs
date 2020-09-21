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
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
        }

        private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;
        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            var result = await ApplicationDbContext
                .Users
                .SingleOrDefaultAsync(
                u =>
                    string.Equals(u.UserName, userName)
            );

            if (result != null && string.Equals(result.UserName, userName, StringComparison.OrdinalIgnoreCase))
                return result;


            return null;
        }

        public async Task<ApplicationUser> FindByIdAsync(string id)
        {
            var result = await ApplicationDbContext
                .Users
                .SingleOrDefaultAsync(
                u =>
                    string.Equals(u.Id, id)
            );

            if (result != null && string.Equals(result.Id, id, StringComparison.OrdinalIgnoreCase))
                return result;


            return null;
        }
    }
}
