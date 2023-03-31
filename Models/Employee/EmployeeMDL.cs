using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static PROPLASTICSAPI.Globals.Globals;

namespace PROPLASTICSAPI.Models.Employee
{

    public class EmployeeMDL
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public object EmployeeType { get; set; }
        public int? Department { get; set; }
        public int? Branch { get; set; }
        public int? Position { get; set; }
        public int? ApplicationUserID { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LoginTypes U_LoginType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Department U_Department { get; set; }

    }

   
}