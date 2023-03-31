using PROPLASTICSAPI.Models;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace PROPLASTICSAPI.BLL.Login
{
    public class LogResponse
    {
        public int EmployeeID { get; set; }
        public string Session { get; set; }
        public int InternalKey { get; set; }
        public string UserName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LoginTypes LoginTypes { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Department Department { get; set; }

    }
}