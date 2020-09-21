using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Services.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationUserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<ApplicationUser> FindByIdAsync(string id)
        {
            return await _unitOfWork.ApplicationUsers.FindByIdAsync(id);
        }

        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            return await _unitOfWork.ApplicationUsers.FindByNameAsync(userName);
        }
    }
}
