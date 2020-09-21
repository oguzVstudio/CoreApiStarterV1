using System;
using System.Collections.Generic;
using System.Text;

namespace sTest.BusinessLogic.Settings
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public TimeSpan TokenLifetime { get; set; }
    }
}
