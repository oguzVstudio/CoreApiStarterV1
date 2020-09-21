using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sTest.MetaData.Services.Services
{
    public class SellerTargetService : ISellerTargetService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SellerTargetService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<SellerTargetTable> GetSellersTarget(int month, int year)
        {
            return _unitOfWork.SellerTargetTableRepository.Find(u => u.Month == month && u.Year == year);
        }

        public IEnumerable<SellerTargetTable> GetSellerTarget(int sellerId, int month, int year)
        {
            return _unitOfWork.SellerTargetTableRepository.Find(u => u.SellerId == sellerId && u.Month == month && u.Year == year);
        }
    }
}
