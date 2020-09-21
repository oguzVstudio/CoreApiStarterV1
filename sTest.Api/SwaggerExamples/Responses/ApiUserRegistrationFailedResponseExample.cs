using sTest.Api.Responses.Version1.ApiLogin;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.SwaggerExamples.Responses
{
    public class ApiUserRegistrationFailedResponseExample : IExamplesProvider<ApiAuthFailedResponse>
    {
        public ApiAuthFailedResponse GetExamples()
        {
            return new ApiAuthFailedResponse
            {
                Errors = new List<string>
               {
                   "One or more errors occured"
               }
            };
        }
    }
}
