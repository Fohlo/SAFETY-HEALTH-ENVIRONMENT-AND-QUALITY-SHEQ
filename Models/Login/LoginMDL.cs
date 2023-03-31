using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROPLASTICSAPI.Models
{
    public class LoginMDL
    {


        public string CompanyDB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoginTypes LoginType { get; set; }
        public Department Department { get; set; }
    }

   public enum LoginTypes
        {
            None = 0,
            Originator = 1,
            Driver = 2,
            Admin = 3,            
            Manager = 4,
            Sheq = 5,
            Artisan = 6,
            Formen =7,
            Supervisor = 8,
            user = 9

    }

    public enum Department
    {
         None = 0,
        SHEQ = 1,
        ENGINEERING = 2,
        SHE = 3,
        Ridge = 4,
        Security = 5,
        Logistics = 6,
        Production = 7,
        IT = 8

    }
}