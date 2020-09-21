using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sTest.Api.Interfaces.Installers;
using sTest.Api.Interfaces.Jobs.RecurringJobs;
using sTest.Api.Interfaces.ScheduleManagers;
using sTest.Api.Jobs.RecurringJobs;
using sTest.Api.ScheduleManagers;
using sTest.BusinessLogic.Interfaces;
using sTest.BusinessLogic.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Installers
{
    public class ScopedServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IOrderSalesBatchJob, OrderSalesBatchJob>();
            services.AddScoped<IOrderSalesJobManager, OrderSalesJobManager>();
        }
    }
}
