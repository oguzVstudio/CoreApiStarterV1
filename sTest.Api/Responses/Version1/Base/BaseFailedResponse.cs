using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Responses.Version1.Base
{
    public class BaseFailedResponse
    {
        public BaseFailedResponse()
        {
            this.Success = false;
        }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
