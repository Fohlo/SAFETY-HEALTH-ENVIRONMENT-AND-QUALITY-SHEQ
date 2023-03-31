using PROPLASTICSAPI.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROPLASTICSAPI.BLL.Session
{
    public class SessionBLL
    {

        
            public static Models.Session.SessionMDL CreateSession(Models.Session.SessionMDL session)
            {
            // check if the session has already been created etc
            Globals.Globals.AuthSessions.Add(session.SessionID, session);
                return session;
            }

            public static string ValidateAppSession(string abc)
            {
                string sessionId = abc;
                if (Globals.Globals.AuthSessions.ContainsKey(sessionId))
                    return sessionId;
                else
                    throw new Exception("User not Logged in");
            }


     }

    
}