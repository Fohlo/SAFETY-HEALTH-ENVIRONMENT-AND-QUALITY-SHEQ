using PROPLASTICSAPI.Models.Engineering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.BLL.Engineering
{
    public class HarzadousWorkPermitBLL
    {
        public static HarzadousWorkPermitMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "HZDWKPMT(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<HarzadousWorkPermitMDL>(data);
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


        public static List<HarzadousWorkPermitMDL> get(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<HarzadousWorkPermitMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<HarzadousWorkPermitMDL>>(infor));
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


        public static string Post(string session, PostHarzadousWorkPermitMDL data)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "HZDWKPMT");
                var Posresult = JsonConvert.DeserializeObject<HarzadousWorkPermitMDL>(Post);
                return " Harzadous Work Permit Report Document Has been created " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchHarzadousWorkPermitMDL data, int Doc)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "HZDWKPMT(" + Doc + ")");
                return " Harzadous Work Permit Report has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

