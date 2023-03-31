using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using static PROPLASTICSAPI.Globals.Globals;

namespace PROPLASTICSAPI.Models.Session
{
    public class SessionMDL
    {

        public CookieCollection B1Cookie { get; set; }
        public long UserID { get; set; } // the applicationUserKey. the actual code of the user. 
        public string Username { get; set; } // the one used by a user to log in into the system. Wchi happens to be the userCode in b1 (displayed to tne user)
        public long EmployeeID { get; set; } // The id of this user as an employee
        public string EmployeeName { get; set; } // the name of this user as an employee (Displayed to the user)
        public string SessionID { get; set; } // session id of the API which happens to be the same as the b1 sessionID if not a shared license is in use
        public double GMTHrs { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LoginTypes LoginType { get; set; } // this is the Position of the user as an employee in sap b1
        [JsonConverter(typeof(StringEnumConverter))]
        public Department Department { get; set; } // this is the Department of the user as an employee in sap b1

    }

    public class MultipleSession
    {
        public string MainSession { get; set; }
        public string BricksSession { get; set; }
        public CookieCollection BricksCookie { get; set; }
        public string ConcreteSession { get; set; }
        public CookieCollection ConcreteCookie { get; set; }
    }

    public class LogModel
    {
        public string Session { get; set; }
        public CookieCollection Cookie { get; set; }
    }
}