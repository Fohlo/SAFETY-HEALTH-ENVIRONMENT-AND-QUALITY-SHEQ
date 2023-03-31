using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROPLASTICSAPI.BLL.Session;
using PROPLASTICSAPI.VC;

namespace PROPLASTICSAPI.BLL
{
    public class Pipeline
    {

        public static string Get(string session, string clause)
        {
            try
            {
                string sessionId = SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, clause);

                //string ddfOnlyJson = ClassVC.B1JsonListToApiJson2(ddfJson).ListValues;
                return ddfJson;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //instead of creating a while loops specific to a B1 Object this does all the calls to any objects and brings back the data as strings then
        //its from where you made the call that you convert the data to the specific JsonObject 
        public static List<string> GetMultiple(string Session, string Clause)
        {
            try
            {
                var selectClause = Clause;
                bool isListEnded = false;

                var Data = new List<string>();

                string sessionId = BLL.Session.SessionBLL.ValidateAppSession(Session);

                long user = Globals.Globals.AuthSessions[sessionId].EmployeeID;


                while (!isListEnded)
                {
                    string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, selectClause);

                    var listObj = ClassVC.B1JsonListToApiJson2(ddfJson);

                    // var returnedItems = JsonConvert.DeserializeObject<List<object>>(listObj.ListValues);
                    selectClause = listObj.NextLink;

                    if (selectClause == "")
                        isListEnded = true;

                    Data.Add(listObj.ListValues);

                }

                return Data;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> GetMultiples(string Session, string Clause)
        {
            try
            {
                var selectClause = Clause;
                bool isListEnded = false;

                var Data = new List<string>();

                string sessionId = BLL.Session.SessionBLL.ValidateAppSession(Session);

                long user = Globals.Globals.AuthSessions[sessionId].EmployeeID;
                int i = 0;

                while (!isListEnded)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, selectClause);

                    var listObj = ClassVC.B1JsonListToApiJson2(ddfJson);

                    // var returnedItems = JsonConvert.DeserializeObject<List<object>>(listObj.ListValues);
                    selectClause = listObj.NextLink;

                    if (selectClause == "")
                        isListEnded = true;

                    Data.Add(listObj.ListValues);

                    i++;
                }

                return Data;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //all posting shall be done here and result is a string which will be converted to the origin
        public static string Post(string session, string Data, string Object)
        {
            try
            {
                string sessionId = SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Post2(Globals.Globals.AuthSessions[sessionId].B1Cookie, Object, Data);
                //string DDFjson = ClassVC.B1JsonListToApiJson(ddfJson);

                return ddfJson;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, string data, string Object)
        {
            try
            {
                string sessionId = SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Patch(Globals.Globals.AuthSessions[sessionId].B1Cookie, Object, data);

                return "Patched";
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> multiples(string Session, string Clause)
        {
            try
            {
                var selectClause = Clause;
                bool isListEnded = false;

                var Data = new List<string>();

                string sessionId = BLL.Session.SessionBLL.ValidateAppSession(Session);


                while (!isListEnded)
                {
                    string ddfJson = SLY.Class1.get3(Globals.Globals.AuthSessions[sessionId].B1Cookie, selectClause);

                    var listObj = ClassVC.B1JsonListToApiJson2(ddfJson);

                    // var returnedItems = JsonConvert.DeserializeObject<List<object>>(listObj.ListValues);
                    selectClause = listObj.NextLink;

                    if (selectClause == "")
                        isListEnded = true;

                    Data.Add(listObj.ListValues);

                }

                return Data;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
