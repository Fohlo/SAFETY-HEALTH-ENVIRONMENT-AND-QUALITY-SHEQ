using PROPLASTICSAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROPLASTICSAPI.Models.Engineering;

namespace PROPLASTICSAPI.BLL.Engineering
{
    public class WeeklyChecklistBLL
    {
        public static WeeklyChecklistMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "DAILYCHECKLIST(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<WeeklyChecklistMDL>(data);
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


        public static List<WeeklyChecklistMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<WeeklyChecklistMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<WeeklyChecklistMDL>>(infor));
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


        public static string Post(string session, PostWeeklyChecklistMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "DAILYCHECKLIST");
                var Posresult = JsonConvert.DeserializeObject<WeeklyChecklistMDL>(Post);
                return "Weekly Checklist Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchWeeklyChecklistMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "DAILYCHECKLIST(" + Doc + ")");
                return "Weekly Checklist has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

