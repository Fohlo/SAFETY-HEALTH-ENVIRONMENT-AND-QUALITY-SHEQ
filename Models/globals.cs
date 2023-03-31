using PROPLASTICSAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROPLASTICSAPI.BLL.Login;

namespace PROPLASTICSAPI.Globals
{
    public class Globals

    {
        
        public static Dictionary<string, Models.Session.SessionMDL> AuthSessions = new Dictionary<string, Models.Session.SessionMDL>();
        public static Dictionary<string, Models.Session.MultipleSession> OtherDBs = new Dictionary<string, Models.Session.MultipleSession>();
        public static Models.Session.MultipleSession Sesssions { get; set; }
        //public static string SLURL = "https://stldb:50000/b1s/v1/";
        // public static string SLURL = "https://betadb1:50000/b1s/v1/";
        public static string SLURL { get; set; }
        public static LoginMDL Login { get; set; }
        public static LogResponse Response { get; set; }
        public enum Responses
        {
            //responses for non list requests
            Success, //operation succeeded
            Failure, //operation failed coz of resource not found. not necessarily an error
            //Responses for list requests
            Full, //success and there is data
            Empty, //success but no data was found
            //Common responses
            Error, // An Erro Encountered in the operation. Server error in most if not all cases
            Validate, // requests a client to validate his request 
            Authenticate, // requests a client to login first to get the response
            Warning, // a warning to the user
        }

        public static DateTime LoginTime { get; set; }
    
        public enum YesOrNo
        {
            Yes, // for yes
            No,
            None
        }
        public enum YOrN
        {
            Y = 1,
            N = 2
        }
      
       

        public enum DocumentAuthorizationStatusEnum
        {
            dasWithout,
            dasPending,
            dasApproved,
            dasRejected,
            dasGenerated,
            dasGeneratedbyAuthorizer,
            dasCancelled
        }

        //[JsonConverter(typeof(StringEnumConverter))]
        public enum TyesorTno
        {
            tYES = 1,
            tNO = 2
        }


        public enum B1YesOrNo
        {
            tYES = 1, // for yes
            tNO = 0
        }


        public enum Bostatus
        {
            none = 0,
            bost_Open = 1,
            bost_Close = 2,
            bost_Paid = 3,
            bost_Delivered = 4
        }
        public enum Gatepass
        {
            None = 0,
            In = 1,
            Out = 2,
            Done = 3,
            Discarded = 4
        }

        public enum Load
        {
            None = -1,
            Empty = 0,
            Loaded = 2,
            Solo = 1
        }

        public enum Choose
        {
            none = -1,
            No = 0,
            Yes = 1

        }
        public enum DataB
        {   None = 0,
            Bricks = 1,
            Tiles =2,
        }

        public enum DocStatus
        {
            cdsClosed = 0,
            cdsOpen = 1
        }

        public enum Status
        {
            Closed = 1,
            Open = 2,
            none
        }
    }

}

