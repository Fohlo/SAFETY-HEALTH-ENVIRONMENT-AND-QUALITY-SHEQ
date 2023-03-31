using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROPLASTICSAPI.BLL.Session;
using PROPLASTICSAPI.BLL.Sheq;
using PROPLASTICSAPI.Models;
using PROPLASTICSAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PROPLASTICSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HazardReportController : Controller
    {

        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.get(session, Doc)) };
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
                var query = "HAZARDRPT?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostHazardReportMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc, PatchHazardReportMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.Patch(session, data, Doc)) };
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
        [Route("GetByNatureOfHazard")]
        public ErrorMDL NatureOfHazard(string session, string NatureOfHazard)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HAZARDRPT?$filter = U_NatureOfHazard eq '" + NatureOfHazard + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.get(session, query)) };
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
                var query = "HAZARDRPT?$filter = U_Department eq '" + Department + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.get(session, query)) };
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
        [Route("GetByHazardDescription")]
        public ErrorMDL HazardDescr(string session, string HazardDescr)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "HAZARDRPT?$filter = U_HazardDescr eq '" + HazardDescr + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.get(session, query)) };
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
                var query = "HAZARDRPT?$filter = U_Date eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }


        //[HttpPut]
        //[Route("Put")]
        //public ErrorMDL Put(string session, int Doc, PatchHazardReportMDL data)
        //{
        //    try
        //    {
        //        SessionBLL.ValidateAppSession(session);
        //        return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.Patch(session, data, Doc)) };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ErrorMDL
        //        {
        //            Error = ex.Message
        //        };
        //    }
        //}


        //[HttpDelete]
        //[Route("Delete")]
        //public ErrorMDL Delete(string session, int Doc, PatchHazardReportMDL data)
        //{
        //    try
        //    {
        //        SessionBLL.ValidateAppSession(session);
        //        return new ErrorMDL { Success = JsonConvert.SerializeObject(HazardReportBLL.Patch(session, data, Doc)) };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ErrorMDL
        //        {
        //            Error = ex.Message
        //        };
        //    }
        //}

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

   
