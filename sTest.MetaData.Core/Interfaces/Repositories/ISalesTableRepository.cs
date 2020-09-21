using sTest.MetaData.Core.Interfaces.Repositories.Base;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.Repositories
{
    public interface ISalesTableRepository : IRepository<SalesTable>
    {
        Task<SalesTable> GetSalesByIdAsync(int id);
        Task<IEnumerable<SalesTable>> GetSalesAsync();
    }
}
