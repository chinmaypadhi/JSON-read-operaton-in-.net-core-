using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Read_opeartion_using_JSON
{
 public class alldata
    {
        public List<clsInfoData> infoData { get; set; }
        public string status { get; set; }
        public string strMessage { get; set; }
    }

 public class clsInfoData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }
class Program
    {
        static void Main(string[] args)
        {

            string url = "https://localhost:44361/api/values/getAllData";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            string jsonValue = "";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)  
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                jsonValue = reader.ReadToEnd();
            }

            alldata websitePosts = JsonConvert.DeserializeObject<alldata>(jsonValue);

        }
    }
}
