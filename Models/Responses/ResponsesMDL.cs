using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROPLASTICSAPI.Models.Responses
{
    public class ResponseMDL
    {
        public Globals.Globals.Responses MyResponse { get; set; }
        public string ResponseDetails { get; set; }
        public string TechnicalDetails { get; set; }
    }
}