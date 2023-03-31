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

namespace PROPLASTICSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviationWaiverRequestController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.get(session, Doc)) };
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
                var query = "DWR?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostDWRMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc, PatchDWRMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.Patch(session, data, Doc)) };
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
        [Route("GetByProductType")]
        public ErrorMDL NatureOfInd(string session, string NatureOfInd)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "DWR?$filter = U_ProductType eq '" + NatureOfInd + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.get(session, query)) };
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
        [Route("GetByRequestingDepartment")]
        public ErrorMDL Department(string session, string Department)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "DWR?$filter = U_ReqDpt eq '" + Department + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.get(session, query)) };
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
        [Route("GetByDateIssued")]
        public ErrorMDL IncidentSeverity(string session, string IncidentSeverity)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "DWR?$filter = U_DateIssued eq '" + IncidentSeverity + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.get(session, query)) };
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
                var query = "DWR?$filter = U_Date eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DeviationWaiverRequestBLL.get(session, query)) };
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
        //public ErrorMDL Put(string session, int Doc, PatchAccidentReportMDL data)
        //{
        //    try
        //    {
        //        SessionBLL.ValidateAppSession(session);
        //        return new ErrorMDL { Success = JsonConvert.SerializeObject(AccidentReportBLL.Patch(session, data, Doc)) };
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
        //public ErrorMDL Delete(string session, int Doc, PatchAccidentReportMDL data)
        //{
        //    try
        //    {
        //        SessionBLL.ValidateAppSession(session);
        //        return new ErrorMDL { Success = JsonConvert.SerializeObject(AccidentReportBLL.Patch(session, data, Doc)) };
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
