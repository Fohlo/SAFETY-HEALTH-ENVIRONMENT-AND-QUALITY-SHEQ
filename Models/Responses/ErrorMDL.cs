using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROPLASTICSAPI.Models
{
    public class ErrorMDL
    {
        public string Error { get; set; }
        public string Success { get; set; }
    }

    public class B1error
    {
        public Errors error { get; set; }
    }

    public class Errors
    {
        public int code { get; set; }
        public Message message { get; set; }
    }

    public class Message
    {
        public string lang { get; set; }
        public string value { get; set; }
    }

}
