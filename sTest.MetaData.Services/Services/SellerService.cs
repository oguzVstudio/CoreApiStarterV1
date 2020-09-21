using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Services.Services
{
    public class SellerService : ISellerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SellerService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<SellerTable> GetSellerByIdAsync(int id)
        {
            return await _unitOfWork.SellerTableRepository.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<SellerTable>> GetSellersAsync()
        {
            return await _unitOfWork.SellerTableRepository.GetAllAsync();
        }
    }
}
