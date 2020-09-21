using sTest.MetaData.Core.Interfaces.Repositories.Base;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser> FindByIdAsync(string id);
        Task<ApplicationUser> FindByNameAsync(string userName);
    }
}
