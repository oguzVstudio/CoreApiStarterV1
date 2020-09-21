using sTest.Api.Requests.Version1.ApiLogin;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.SwaggerExamples.Requests
{
    public class ApiUserLoginRequestExample : IExamplesProvider<ApiUserLoginRequest>
    {
        public ApiUserLoginRequest GetExamples()
        {
            return new ApiUserLoginRequest
            {
                UserName = "testUser",
                Password = "123456Aa!",
            };
        }
    }
}
