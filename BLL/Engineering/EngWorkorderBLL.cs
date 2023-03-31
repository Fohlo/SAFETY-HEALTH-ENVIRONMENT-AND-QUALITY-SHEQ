using PROPLASTICSAPI.Models.Engineering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.BLL.Engineering
{
    public class EngWorkorderBLL
    {
        public static WorkorderEngMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "ENGWORKORDER(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<WorkorderEngMDL>(data);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static List<WorkorderEngMDL> get(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<WorkorderEngMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<WorkorderEngMDL>>(infor));
                    }
                    return Alldata;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static string Post(string session, PostWorkorderEngMDL data)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "ENGWORKORDER");
                var Posresult = JsonConvert.DeserializeObject<WorkorderEngMDL>(Post);
                return " Workorder Report Document Has been created " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchWorkorderEngMDL data, int Doc)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "ENGWORKORDER(" + Doc + ")");
                return " Work Order Report has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

