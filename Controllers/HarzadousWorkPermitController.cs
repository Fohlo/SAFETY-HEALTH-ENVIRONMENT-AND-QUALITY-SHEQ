using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PROPLASTICSAPI.BLL.Session;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROPLASTICSAPI.BLL.Engineering;
using PROPLASTICSAPI.Models.Engineering;
using PROPLASTICSAPI.Models;

namespace PROPLASTICSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HarzadousWorkPermitController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.get(session, Doc)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }



        [HttpGet]
        [Route("GetOpen")]
        public ErrorMDL Get(string session)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HZDWKPMT?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpPost]
        public ErrorMDL Post(string session, PostHarzadousWorkPermitMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.Post(session, data)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }


        [HttpPost]
        [Route("Update")]
        public ErrorMDL Post(string session, int Doc, PatchHarzadousWorkPermitMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.Patch(session, data, Doc)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpGet]
        [Route("GetByJobCardNo")]
        public ErrorMDL NatureOfHazard(string session, string NatureOfJob)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HZDWKPMT?$filter = U_JobCardNo eq '" + NatureOfJob + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpGet]
        [Route("GetByDepartment")]
        public ErrorMDL Department(string session, string Department)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HZDWKPMT?$filter = U_Department eq '" + Department + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpGet]
        [Route("GetBySupervisor")]
        public ErrorMDL Machine(string session, string Machine)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HZDWKPMT?$filter = U_Supervisor eq '" + Machine + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }


        [HttpGet]
        [Route("GetByDate")]
        public ErrorMDL Date(string session, string Date)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HZDWKPMT?$filter = U_Date eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HarzadousWorkPermitBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

