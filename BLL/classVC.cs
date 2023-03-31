using PROPLASTICSAPI.Globals;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace PROPLASTICSAPI.VC
{
    public class ClassVC
    {
        // our dates are in the format yyyy-MM-dd hh:mm:ss
        //public DateTime ReadDateTime(string datestring, string sessionid)// we need to know GTM hours of the client
        //{
        //    // reads date and time in the format yyyy-MM-dd 00:00:00. only cares bwt the date
        //    datestring = datestring.Replace("/", "-");
        //    string[] dt = datestring.Split(' ');
        //    string[] d = dt[0].Split('-');
        //    string[] t;
        //    if (dt.Count() == 2)
        //        t = dt[1].Split(':');
        //    else
        //        t = new string[] { "00", "00", "00" };

        //    double gmt = Globals.Globals.AuthSessions[sessionid].GMTHrs;
        //    return new DateTime(int.Parse(d[0]), int.Parse(d[1]), int.Parse(d[2]), int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2])).AddHours(gmt);
        //}

        public string WriteDateTime(DateTime date)//here we assume this is the UTC now
        {
            //writes both the date n time as given in the datetime
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string WriteDateOnly(DateTime date)
        {
            //we are using a datiteme field but only concerned wth th date part
            return date.ToString("yyyy-MM-dd 00:00:00");
        }

        public string DDMMYYYY(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static DateTime DateFromDDMMYYYY(string date)
        {
            string[] d = date.Split('/');
            return new DateTime(int.Parse(d[2]), int.Parse(d[1]), int.Parse(d[0]));
        }

        public static string DateFormattForDTW(DateTime date)
        {
            return date.ToString("yyyyMMdd");
        }

        public string WP(string myp) // write password , myp-my password
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(myp);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(myp, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    myp = Convert.ToBase64String(ms.ToArray());
                }
            }
            return myp;
        }

        public string RP(string storedp, string myp)  // read password, 
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(storedp);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(myp, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        myp = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return myp;
            }
            catch
            {
                return "error";
            }
        }

        public static string ServerDirectoryURL()
        {
            //string serverdirectory = "http://localhost:15911/";
            string serverdirectory = "http://www.yomilk1.somee.com/";
            //string requestUrl = HttpContext.Current.Request.Url.ToString();
            //string serverdirectory = requestUrl.Substring(0, requestUrl.LastIndexOf('/')) + "/";
            return serverdirectory;
        }

        //public static string ServerDirectoryPhysical()
        //{
        //    string directory = HttpContext.Current.Request.MapPath("~/");
        //    return directory;
        //}

        //public static string GetItemSmallImagePath(string itemCode)
        //{
        //    string imageUri = ServerDirectoryURL() + "Images/Items/" + itemCode + "_s.jpg";
        //    return imageUri;
        //}
        //public static string GetItemLargeImagePath(string itemCode)
        //{
        //    string imageUri = ServerDirectoryURL() + "Images/Items/" + itemCode + "_l.jpg";
        //    return imageUri;
        //}

        //public static string SalesOrderCSVTemplatePath()
        //{
        //    string path = HttpContext.Current.Request.MapPath("~/Files/SalesOrders/SalesOrderCSVTemplate.txt");
        //    return path;
        //}

        //public static string SalesOrderLineCSVTemplatePath()
        //{
        //    string path = HttpContext.Request.MapPath("~/Files/SalesOrders/SalesOrderLineCSVTemplate.txt");
        //    return path;
        //}

        //public static string RemoveNewLine(string myString)
        //{
        //    string replacement = Regex.Replace(myString, @"\t|\n|\r", "");
        //    return replacement;
        //}


        public class B1JsonList
        {
            public string MetaData { get; set; }
            public string ListValues { get; set; }
            public string NextLink { get; set; }
        }

        public static string B1JsonListToApiJson(string b1Json)
        {
            // use this to get lists only. if not a list do not use this. we myt wanna handle a case when a user has sent us an object thats not a list
           
            dynamic item = JsonConvert.DeserializeObject<object>(b1Json);

            var s = item["odata.metadata"];
            //var value = item["value"]; // get the value property which has the required object

            B1JsonList obj = new B1JsonList();

            obj.MetaData = item["odata.metadata"].ToString();
            try { obj.NextLink = item["odata.nextLink"].ToString().Replace("/b1s/v1/", ""); }
            catch { obj.NextLink = ""; }
            var json = JsonConvert.SerializeObject(s);
            obj.ListValues = json.ToString();
            return obj.ListValues;
        }

        public static B1JsonList B1JsonListToApiJson2(string b1Json)
        {
            // use this to get lists only. if not a list do not use this. we myt wanna handle a case when a user has sent us an object thats not a list
            //b1Json = b1Json.Remove('/');
            dynamic item = JsonConvert.DeserializeObject<object>(b1Json);

            //var s = item["odata.metadata"];
            var value = item["value"]; // get the value property which has the required object

            B1JsonList obj = new B1JsonList
            {
                MetaData = item["odata.metadata"].ToString()
            };
            try { obj.NextLink = item["odata.nextLink"].ToString().Replace("/b1s/v1/", ""); }
            catch { obj.NextLink = ""; }
            var json = JsonConvert.SerializeObject(value);
            obj.ListValues = json.ToString();
            return obj;
        }

        public static B1JsonList B1JsonListToApiJson3(string b1Json)
        {
            // use this to get lists only. if not a list do not use this. we myt wanna handle a case when a user has sent us an object thats not a list
            b1Json = b1Json.Replace("Bales/BALES2Collection", "BALES2Collection");
            dynamic item = JsonConvert.DeserializeObject<object>(b1Json);

            //var s = item["odata.metadata"];
            var value = item["value"]; // get the value property which has the required object

            B1JsonList obj = new B1JsonList
            {
                MetaData = item["odata.metadata"].ToString()
            };
            try { obj.NextLink = item["odata.nextLink"].ToString().Replace("/b1s/v1/", ""); }
            catch { obj.NextLink = ""; }
            var json = JsonConvert.SerializeObject(value);
            obj.ListValues = json.ToString();
            return obj;
        }

        public static string JsonObjectToStringJNet(object jsonObject)
        {
            var json = JsonConvert.SerializeObject(jsonObject);
            return json.ToString();
        }

        //public static string B1JsonListNextLink(string b1Json)
        //{
        //    // use this to get lists only. if not a list do not use this. we myt wanna handle a case when a user has sent us an object thats not a list
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    dynamic item = serializer.Deserialize<object>(b1Json);

        //    //var s = item["odata.metadata"];
        //    try
        //    {
        //        string value = item["odata.nextLink"].ToString().Replace("/b1s/v1/", ""); // get the value property which has the required object
        //        return value;
        //    }
        //    catch
        //    {
        //        return "";
        //    }
        //}

        public static string JsonObjectToString(object jsonObject)
        {
            var json = JsonConvert.SerializeObject(jsonObject);
            return json.ToString();
        }
    }
}