using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sTest.Api.Interfaces.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Installers
{
    public class SingletonServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {

        }
    }
}
