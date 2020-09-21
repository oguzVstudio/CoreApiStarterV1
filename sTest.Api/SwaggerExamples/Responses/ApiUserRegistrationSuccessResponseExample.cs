using sTest.Api.Responses.Version1.ApiLogin;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.SwaggerExamples.Responses
{
    public class ApiUserRegistrationSuccessResponseExample : IExamplesProvider<ApiAuthSuccessResponse>
    {
        public ApiAuthSuccessResponse GetExamples()
        {
            return new ApiAuthSuccessResponse
            {
                Token = "any token key",
                RefreshToken = "any refresh token key"
            };
        }
    }
}
