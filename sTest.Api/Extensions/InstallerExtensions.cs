using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sTest.Api.Interfaces.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Extensions
{
    public static class InstallerExtensions
    {
        public static void InstallServicesInAssemby(this IServiceCollection services, IConfiguration configuration)
        {
            var classImplementingInstallers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
                typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

            classImplementingInstallers.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
