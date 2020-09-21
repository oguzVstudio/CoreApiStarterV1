using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sTest.MetaData.Core.Interfaces.Services
{
    public interface ISellerTargetService
    {
        IEnumerable<SellerTargetTable> GetSellerTarget(int sellerId, int month, int year);
        IEnumerable<SellerTargetTable> GetSellersTarget(int month, int year);
    }
}
