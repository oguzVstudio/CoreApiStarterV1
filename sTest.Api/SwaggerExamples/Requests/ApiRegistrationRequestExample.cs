using sTest.Api.Requests.Version1.ApiLogin;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.SwaggerExamples.Requests
{
    public class ApiRegistrationRequestExample : IExamplesProvider<ApiUserRegistrationRequest>
    {
        public ApiUserRegistrationRequest GetExamples()
        {
            return new ApiUserRegistrationRequest
            {
                UserName = "testUser",
                Password = "123456Aa!",
                FirstName = "test",
                LastName = "user",
                Email = "test@test.com",
                PhoneNumber = "901234567890",
            };
        }
    }
}
