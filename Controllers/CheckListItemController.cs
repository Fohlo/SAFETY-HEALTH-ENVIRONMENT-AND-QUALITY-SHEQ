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
    public class CheckListItemController : ControllerBase
    {
        [HttpGet]
        public ErrorMDL Get(string session, string type)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                string query = "ENGCHECKLIST?$filter =U_Type eq '" + type+"'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(CheckListItemsBLL.get(session,query)) };
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
                var query = "ENGCHECKLIST?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(CheckListItemsBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostCheckListItemMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(CheckListItemsBLL.Post(session, data)) };
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
