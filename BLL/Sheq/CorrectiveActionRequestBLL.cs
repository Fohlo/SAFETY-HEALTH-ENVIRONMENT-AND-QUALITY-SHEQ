using Newtonsoft.Json;
using PROPLASTICSAPI.Models.SHEQ;
using System.Collections.Generic;
using System;

namespace PROPLASTICSAPI.BLL.Sheq
{
    public class CorrectiveActionRequestBLL
    {
        public static CAMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "CORRECTIVEEAR(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<CAMDL>(data);
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


        public static List<CAMDL> get(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<CAMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<CAMDL>>(infor));
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


        public static string Post(string session, PostCAMDL data)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "CORRECTIVEEAR");
                var Posresult = JsonConvert.DeserializeObject<CAMDL>(Post);
                return " Corrective Action Request Document Has been created " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchCAMDL data, int Doc)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "CORRECTIVEEAR(" + Doc + ")");
                return " Corrective Action Request Report  has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}



