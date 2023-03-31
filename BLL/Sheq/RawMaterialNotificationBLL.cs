using Newtonsoft.Json;
using PROPLASTICSAPI.Models.SHEQ;
using System.Collections.Generic;
using System;

namespace PROPLASTICSAPI.BLL.Sheq
{
    public class RawMaterialNotificationBLL
    {
        public static RMNMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "ACCIDENTRPT(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<RMNMDL>(data);
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


        public static List<RMNMDL> get(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<RMNMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<RMNMDL>>(infor));
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


        public static string Post(string session, PostRMNMDL data)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "ACCIDENTRPT");
                var Posresult = JsonConvert.DeserializeObject<RMNMDL>(Post);
                return " Raw Material Notification Document Has been created " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchRMNMDL data, int Doc)
        {
            try
            {
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "ACCIDENTRPT(" + Doc + ")");
                return " Raw Material Notification has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}



