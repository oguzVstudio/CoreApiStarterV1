using sTest.Api.Requests.Version1.ApiLogin;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.SwaggerExamples.Requests
{
    public class ApiRefreshTokenRequestExample : IExamplesProvider<ApiRefreshTokenRequest>
    {
        public ApiRefreshTokenRequest GetExamples()
        {
            return new ApiRefreshTokenRequest
            {
                Token = "...",
                RefreshToken = "..."
            };
        }
    }
}
