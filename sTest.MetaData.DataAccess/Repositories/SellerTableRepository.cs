using sTest.MetaData.Core.Interfaces.Repositories;
using sTest.MetaData.Core.Models;
using sTest.MetaData.DataAccess.Data;
using sTest.MetaData.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace sTest.MetaData.DataAccess.Repositories
{
    public class SellerTableRepository : Repository<SellerTable>, ISellerTableRepository
    {
        public SellerTableRepository(ApplicationDbContext context): base(context)
        {

        }

        private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;
    }
}
