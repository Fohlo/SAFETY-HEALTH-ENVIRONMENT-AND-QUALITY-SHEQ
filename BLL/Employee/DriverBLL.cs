using PROPLASTICSAPI.Globals;
using PROPLASTICSAPI.BLL.Responses;
using PROPLASTICSAPI.VC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using PROPLASTICSAPI.Models.Employee;
using Newtonsoft.Json;
using PROPLASTICSAPI.VC;

namespace PROPLASTICSAPI.BLL.Employee
{
    public class EmployeeBLL
    {

        public static B1ProfileMDL UseronLogin(string session, string userId)
        {
            try
            {
                string sessionId = PROPLASTICSAPI.BLL.Session.SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, "Users?$filter=UserCode eq '" + userId + "' &$select=UserName,InternalKey");

                string ddfOnlyJson = ClassVC.B1JsonListToApiJson2(ddfJson).ListValues;
               
                var myDDF = JsonConvert.DeserializeObject<List<B1ProfileMDL>>(ddfOnlyJson);
                return myDDF[0];
            }

          
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static EmployeeMDL Jobdescription(string session, int Internalkey)
        {
            try
            {
                string sessionId = PROPLASTICSAPI.BLL.Session.SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, "EmployeesInfo?$filter=ApplicationUserID eq " + Internalkey + "");

                string ddfOnlyJson = ClassVC.B1JsonListToApiJson2(ddfJson).ListValues;
               
                var myDDF = JsonConvert.DeserializeObject<List<Models.Employee.EmployeeMDL>>(ddfOnlyJson);
                return myDDF[0];

            }
            catch (Exception ex)
            {
                throw new Exception("the user has not been found in b1 please contact admin");
            }
        }


        public static EmployeeMDL DriverName(string session, long Userid)
        {

            try
            {
                string sessionId = PROPLASTICSAPI.BLL.Session.SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, "EmployeesInfo?$filter=EmployeeID eq " + Userid + " &$select = FirstName, LastName");

                string ddfOnlyJson = ClassVC.B1JsonListToApiJson2(ddfJson).ListValues;
               
                var myDDF = JsonConvert.DeserializeObject<List<EmployeeMDL>>(ddfOnlyJson);
                return myDDF[0];
            }
           
            catch (Exception ex)
            {
                throw new Exception(ex.Message+ " user not logged in please login");
            }
        }

        internal static List<DriverMDL> UsersByLoginType(string Session, string LoginType)
        {
            var selectClause = "EmployeesInfo?$filter=U_LoginType eq '"+ LoginType + "'";
            bool isListEnded = false;

            var drivers = new List<DriverMDL>();

            string sessionId = BLL.Session.SessionBLL.ValidateAppSession(Session);
            try
            {
                while (!isListEnded)
                {
                    string ddfJson = SLY.Class1.Get(Globals.Globals.AuthSessions[sessionId].B1Cookie, selectClause);

                    var listObj = ClassVC.B1JsonListToApiJson2(ddfJson);

                    var returnedItems = JsonConvert.DeserializeObject<List<DriverMDL>>(listObj.ListValues);
                    selectClause = listObj.NextLink;

                    if (selectClause == "")
                        isListEnded = true;

                    drivers.AddRange(returnedItems);

                }
                return drivers;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}