using PROPLASTICSAPI.Models.SHEQ;
using Newtonsoft.Json;
using PROPLASTICSAPI.Models.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.BLL.Engineering
{
    public class DailyChecklistBLL
    {
        public static DailyChecklistMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "DAILYCHECKLIST(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<DailyChecklistMDL>(data);
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


        public static List<DailyChecklistMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<DailyChecklistMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<DailyChecklistMDL>>(infor));
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


        public static string Post(string session, PostDailyChecklistMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "DAILYCHECKLIST");
                var Posresult = JsonConvert.DeserializeObject<DailyChecklistMDL>(Post);
                return "Checklist Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchDailyChecklistMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "DAILYCHECKLIST(" + Doc + ")");
                return "Checklist has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

