using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.Services
{
    public interface ISalesTableService
    {
        Task<IEnumerable<SalesTable>> GetSalesAsync();
        Task<SalesTable> GetSalesByIdAsync(int id);
        IEnumerable<SalesTable> GetSalesByEmployeeAsync(int sellerId);
        Task<SalesTable> AddSales(SalesTable entity);
    }
}
