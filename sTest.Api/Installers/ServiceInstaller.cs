using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sTest.Api.Interfaces.Installers;
using sTest.BusinessLogic.Interfaces;
using sTest.BusinessLogic.Services;
using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.DataAccess.UnitOfWork;
using sTest.MetaData.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Installers
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRefreshTokenService, RefreshTokenService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<IIdentityService, IdentityService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IOrderTableService, OrderTableService>();
            services.AddTransient<ISalesTableService, SalesTableService>();
            services.AddTransient<ISellerService, SellerService>();
            services.AddTransient<ISellerTargetService, SellerTargetService>();
        }
    }
}
