using Newtonsoft.Json;
using PROPLASTICSAPI.Models.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPLASTICSAPI.BLL.Engineering
{
    public class CheckListItemsBLL
    {
        public static CheckListItemMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "ENGCHECKLIST(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<CheckListItemMDL>(data);
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
        public static List<CheckListItemMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<CheckListItemMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<CheckListItemMDL>>(infor));
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

        public static List<CheckListItemMDL> gets(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<CheckListItemMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<CheckListItemMDL>>(infor));
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


        public static string Post(string session, PostCheckListItemMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "ENGCHECKLIST");
                var Posresult = JsonConvert.DeserializeObject<CheckListItemMDL>(Post);
                return "Checklist Items Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
