using Newtonsoft.Json;
using PROPLASTICSAPI.Models.SHEQ;
using System.Collections.Generic;
using System;

namespace PROPLASTICSAPI.BLL.Sheq
{
    public class SieveAnalysisReportBLL
    {
        public static SARMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "ACCIDENTRPT(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<SARMDL>(data);
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


        public static List<SARMDL> get(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<SARMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<SARMDL>>(infor));
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


        public static string Post(string session, PostSARMDL data)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "ACCIDENTRPT");
                var Posresult = JsonConvert.DeserializeObject<SARMDL>(Post);
                return " Sieve Analysis Report Document Has been created " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchSARMDL data, int Doc)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "ACCIDENTRPT(" + Doc + ")");
                return " Sieve Analysis Report Report  has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}



