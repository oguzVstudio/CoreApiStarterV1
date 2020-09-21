using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sTest.Api.Interfaces.Installers;
using sTest.BusinessLogic.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Installers
{
    public class HangfireInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var hangfireSettings = new HangfireSettings();
            configuration.Bind(key: nameof(HangfireSettings), hangfireSettings);
            services.AddSingleton(hangfireSettings);

            services.AddHangfire(options =>
            {
                GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute() { Attempts = 0 });
                options.UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
