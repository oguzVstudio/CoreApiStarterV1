using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.Services
{
    public interface ISellerService
    {
        Task<IEnumerable<SellerTable>> GetSellersAsync();
        Task<SellerTable> GetSellerByIdAsync(int id);
    }
}
