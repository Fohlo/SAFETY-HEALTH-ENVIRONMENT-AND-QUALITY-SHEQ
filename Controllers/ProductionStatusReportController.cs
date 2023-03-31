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
    public class ProductionStatusReportController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.get(session, Doc)) };
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
                var query = "ACCIDENTRPT?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostPSRMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc, PatchPSRMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.Patch(session, data, Doc)) };
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
        [Route("GetByShift")]
        public ErrorMDL NatureOfInd(string session, string NatureOfInd)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "ACCIDENTRPT?$filter = U_Shift  eq '" + NatureOfInd + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.get(session, query)) };
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
        [Route("GetByStatus")]
        public ErrorMDL Department(string session, string Department)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "ACCIDENTRPT?$filter = U_Status eq '" + Department + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.get(session, query)) };
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
        public ErrorMDL IncidentSeverity(string session, string IncidentSeverity)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "ACCIDENTRPT?$filter = U_Machine eq '" + IncidentSeverity + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.get(session, query)) };
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
                var query = "ACCIDENTRPT?$filter = U_Date eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionStatusReportBLL.get(session, query)) };
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

