using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Contracts_Routes_.v1
{
    public class ApiRoutes
    {
        public const string Route = "api";
        public const string Version = "v1";
        public const string Base = Route + "/" + Version;

        public static class Identity
        {
            public const string Login = Base + "/identity/login";
            public const string Register = Base + "/identity/register";
            public const string Refresh = Base + "/identity/refresh";
        }

        public static class Seller
        {
            public const string GetSellerSales = Base + "/seller/getsellersales";
        }
    }
}
