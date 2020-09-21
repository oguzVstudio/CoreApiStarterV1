﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Requests.Version1.ApiLogin
{
    public class ApiUserRegistrationRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string LastName { get; set; }
    }
}
