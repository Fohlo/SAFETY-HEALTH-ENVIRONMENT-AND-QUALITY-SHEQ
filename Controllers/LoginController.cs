using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROPLASTICSAPI.BLL.Login;
using PROPLASTICSAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PROPLASTICSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        public ErrorMDL Post(UseMDL users)
        {
            try
            {
                //
                
                LoginMDL login = new LoginMDL
                {
                    CompanyDB = users.CompanyDB,
                    UserName = users.UserName,
                    Password = users.Password
                };

               
                 SLY.Class1.SLURL = "https://192.192.192.192:50000/b1s/v1/";
                var userlogin = LoginBLL.Login(login);

                var Success = new ErrorMDL
                {
                    Success = JsonConvert.SerializeObject(userlogin)
                };
                return Success;
            }
            catch (Exception ex)
            {
                var error = new ErrorMDL
                {
                    Error = ex.Message
                };
                return error;
            }

        }


    }
}
