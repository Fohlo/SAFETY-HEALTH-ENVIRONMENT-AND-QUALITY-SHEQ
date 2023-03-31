using PROPLASTICSAPI.Globals;
using PROPLASTICSAPI.Models;
using PROPLASTICSAPI.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace PROPLASTICSAPI.BLL.Responses
{
    public class ResponseBLL
    {
        public static string WebExceptionJsonString(WebException webException)
        {
            // this method  creates a web exception error and pases it as a json Response string
            using (WebResponse response = webException.Response)
            {
                HttpWebResponse httpResponse = (HttpWebResponse)response;
                if (httpResponse == null)
                    throw new Exception(ResponseBLL.ErrorString(Globals.Globals.Responses.Error, "no response from sap b1. Please ensure that the service layer is accessible", ""));
                //Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                using (Stream data = response.GetResponseStream())
                using (var reader = new StreamReader(data))
                {
                    string text = reader.ReadToEnd();
                    var exception = JsonConvert.DeserializeObject<B1error>(text);
                    //string exception = ErrorString(Globals.Globals.Responses.Error, text + "(code: " + httpResponse.StatusCode.ToString() + ")", "");
                    return exception.error.message.value;
                }
            }
        }
        public class B1error
        {
            public Errors error { get; set; }
        }
        public class Errors
        {
            public int code { get; set; }
            public Message message { get; set; }
        }

        public class Message
        {
            public string lang { get; set; }
            public string value { get; set; }
        }


        public static string ErrorString(Globals.Globals.Responses response, string details = "", string techDetails = "")
        {
            Models.Responses.ResponseMDL res = new Models.Responses.ResponseMDL
            {
                MyResponse = response,
                ResponseDetails = details,
                TechnicalDetails = techDetails
            };
            // we now need to convert this object to a json string
            string errJson = ResponseJson(res);
            return errJson;
        }

        static string ResponseJson(Models.Responses.ResponseMDL res)
        {
            var json = JsonConvert.SerializeObject(res);
            string resJson = json.ToString();
            return resJson;
        }

        static Models.Responses.ResponseMDL ResponseObject(Globals.Globals.Responses response, string details = "", string techDetails = "")
        {
            Models.Responses.ResponseMDL res = new ResponseMDL
            {
                MyResponse = response,
                ResponseDetails = details,
                TechnicalDetails = techDetails
            };
            return res;
        }

        public static Models.Responses.ResponseMDL ResponseOBJFromJson(string resJson)
        {
            // we myt have another error string being parsed here so we need to check if we received the correct object here. if not create a new object
            resJson = resJson.Trim();
            if ((resJson.StartsWith("{") && resJson.EndsWith("}"))) //For object  || (resJson.StartsWith("[") && resJson.EndsWith("]"))) //For array
            {
                try
                {
                    //var obj = JToken.Parse(resJson);
                    var myVrv = JsonConvert.DeserializeObject<Models.Responses.ResponseMDL>(resJson);
                    return myVrv;
                }
                catch (Exception ex)
                {
                    return ResponseObject(Globals.Globals.Responses.Error, ex.Message, "");
                }
            }
            else
            {
                return ResponseObject(Globals.Globals.Responses.Error, resJson, ""); // the error passes here is not ours
            }
        }

    }
}