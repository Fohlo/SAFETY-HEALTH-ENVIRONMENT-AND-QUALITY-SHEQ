using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using PROPLASTICSAPI.Models;
using PROPLASTICSAPI.Models.Session;
using PROPLASTICSAPI.BLL.Session;
using PROPLASTICSAPI.BLL.Employee;
using PROPLASTICSAPI.BLL.Login;
using PROPLASTICSAPI.Globals.Login;
using PROPLASTICSAPI.BLL.Responses;
using PROPLASTICSAPI.Globals;

namespace PROPLASTICSAPI.BLL.Login
{
    public class LoginBLL
    {
        public static LogResponse Login(LoginMDL login)
        {
            var resp = new HttpResponseMessage();
            try
            {
                var res = LoginBLL.LoginB1(login);

                // we need to create a session here
                string b1Session = "";
                if (res.B1Cookie.Count > 0)
                {
                    foreach (Cookie cookie1 in res.B1Cookie)
                    {
                        if (cookie1.Name.ToLower() == "b1session")
                            b1Session = cookie1.Value;

                    }
                }

                // check if the session exist already
                SessionMDL session = new SessionMDL
                {
                    B1Cookie = res.B1Cookie,
                    LoginType = login.LoginType,
                    SessionID = b1Session,
                    EmployeeName = login.UserName,
                    Username = login.UserName
                };
                SessionBLL.CreateSession(session);

                resp.Content = new StringContent(b1Session);
                var ab = resp.ToString();
                var Driver = EmployeeBLL.UseronLogin(b1Session.ToString(), login.UserName);
                var dets = EmployeeBLL.Jobdescription(b1Session.ToString(), Driver.InternalKey);
                
                //session.EmployeeID = dets.EmployeeID;
                session.EmployeeName = Driver.UserName;

                LogResponse Details = new LogResponse
                {
                    UserName = dets.FirstName + " "+dets.LastName,
                    Session = b1Session.ToString(),
                    InternalKey = Driver.InternalKey,
                    EmployeeID = dets.EmployeeID,
                    LoginTypes = dets.U_LoginType,
                    Department = dets.U_Department,
                };

                //Globals.Globals.AuthSessions[session.SessionID].LoginType = dets.U_LoginType;
                Globals.Globals.AuthSessions[session.SessionID].UserID = Driver.InternalKey;
                Globals.Globals.AuthSessions[session.SessionID].EmployeeID = dets.EmployeeID;

                 return Details;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        static string LoginObjectJson(LoginMDL login)
        {
            var json = JsonConvert.SerializeObject(login);
            return json.ToString();
        }

        static string LoginJsonObject(string loginJson)
        {
            var json = JsonConvert.DeserializeObject<LoginMDL>(loginJson);
            return json.ToString();
        }

        public static SLY.Class1.LoginResponseOBJ LoginB1(LoginMDL login)
        {
            try
            { 
                var res = SLY.Class1.Login(LoginObjectJson(login));
                return res;
            }
         
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static LogModel LoginMulti(LoginMDL login)
        {
            var resp = new HttpResponseMessage();
            try
            {
                var res = LoginBLL.LoginB1(login);

                // we need to create a session here
                string b1Session = "";
                //if (res.B1Cookie.Count > 0)
                //{
                //    foreach (Cookie cookie1 in res.B1Cookie)
                //    {
                //        if (cookie1.Name.ToLower() == "b1session")
                //            b1Session = cookie1.Value;

                //        var cookie = new CookieHeaderValue(cookie1.Name, cookie1.Value)
                //        {
                //            Expires = DateTimeOffset.Now.AddDays(1),
                //            Domain = "STLDB",
                //            Path = "/"
                //        };
                //        resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });
                //    }
                //}

                return new LogModel
                {
                    Cookie = res.B1Cookie,
                    Session = b1Session
                };


            }
                catch (Exception ex)
                {
                throw new Exception(ex.Message);
            }
            }

        public static string Logout(string session, string logout)
        {
            try
            {
                string sessionId = SessionBLL.ValidateAppSession(session);
                string ddfJson = SLY.Class1.Logout(Globals.Globals.AuthSessions[sessionId].B1Cookie, logout);
                return "user has succesfully logged out now ";
            }
            catch (WebException ex)
            {
                throw new Exception(ResponseBLL.WebExceptionJsonString(ex));
            }

        }

    }
}