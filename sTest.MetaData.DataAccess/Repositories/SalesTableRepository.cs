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
    public class SalesTableRepository : Repository<SalesTable>, ISalesTableRepository
    {
        public SalesTableRepository(ApplicationDbContext context) :base(context)
        {
        }
        private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;

        public async Task<SalesTable> GetSalesByIdAsync(int id)
        {
            var res = await ApplicationDbContext.SalesTables
                .Include(u => u.Order)
                .Include(u=>u.Seller).SingleOrDefaultAsync(u => u.Id == id);

            return res;
        }

        public async Task<IEnumerable<SalesTable>> GetSalesAsync()
        {
            var res = await ApplicationDbContext.SalesTables
                .Include(u => u.Order)
                .Include(u => u.Seller).ToListAsync();

            return res;
        }
    }
}
