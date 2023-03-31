using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROPLASTICSAPI.Models
{
    public class UseMDL
    {
        public bool MultiUser { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string CompanyDB { get; set; }
        public string Stores { get; set; }
        public string Token { get; set; }
        public string Version { get; set; }
        public string Release { get; set; }
    }
}