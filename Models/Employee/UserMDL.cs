using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROPLASTICSAPI.Models.Employee
{
    public class UserMDL
    {
        public string fullName { get; set; }

        public string b1Session { get; set; }

    }

    public class DriverMDL {

        public int EmployeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }


}