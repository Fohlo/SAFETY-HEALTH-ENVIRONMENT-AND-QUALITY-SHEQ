using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PROPLASTICSAPI.BLL.Session;
using PROPLASTICSAPI.BLL.Sheq;
using PROPLASTICSAPI.Models;
using PROPLASTICSAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROPLASTICSAPI.BLL.Engineering;
using PROPLASTICSAPI.Models.Engineering;

namespace PROPLASTICSAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WorkorderEngController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.get(session, Doc)) };
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
                var query = "ENGWORKORDER?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostWorkorderEngMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc, PatchWorkorderEngMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.Patch(session, data, Doc)) };
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
        [Route("GetByNatureOfJob")]
        public ErrorMDL NatureOfHazard(string session, string NatureOfJob)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "ENGWORKORDER?$filter = U_NatureOfJob eq '" + NatureOfJob + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.get(session, query)) };
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
                var query = "ENGWORKORDER?$filter = U_Department eq '" + Department + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.get(session, query)) };
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
        [Route("GetByMachine")]
        public ErrorMDL Machine(string session, string Machine)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "ENGWORKORDER?$filter = U_Machine eq '" + Machine + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.get(session, query)) };
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
        [Route("GetByFaultDate")]
        public ErrorMDL Date(string session, string Date)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "ENGWORKORDER?$filter = U_FaultDate eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EngWorkorderBLL.get(session, query)) };
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

