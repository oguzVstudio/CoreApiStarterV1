using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Services.Services
{
    public class SalesTableService : ISalesTableService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesTableService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<SalesTable>> GetSalesAsync()
        {
            return await _unitOfWork.SalesTableRepository.GetSalesAsync();
        }

        public async Task<SalesTable> GetSalesByIdAsync(int id)
        {
            return await _unitOfWork.SalesTableRepository.GetSalesByIdAsync(id);
        }

        public IEnumerable<SalesTable> GetSalesByEmployeeAsync(int sellerId)
        {
            return _unitOfWork.SalesTableRepository.Find(u => u.SellerId == sellerId);
        }

        public async Task<SalesTable> AddSales(SalesTable entity)
        {
            await _unitOfWork.SalesTableRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();

            return await this.GetSalesByIdAsync(entity.Id);
        }

    }
}
