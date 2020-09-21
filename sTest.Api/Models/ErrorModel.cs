using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Models
{
    public class ErrorModel
    {
        [JsonProperty(PropertyName = "FieldName")]
        public string FieldName { get; set; }

        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }
    }
}
