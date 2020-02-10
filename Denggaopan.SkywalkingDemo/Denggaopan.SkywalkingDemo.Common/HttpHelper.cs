using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Denggaopan.SkywalkingDemo.Common
{
    public class HttpHelper
    {
        public static string Get(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var res = client.GetAsync(url).Result;
                if (res.StatusCode == HttpStatusCode.OK)
                {
                    return res.Content.ReadAsStringAsync().Result;
                }
            }
            return null;
        }

        public static string Get2(string url)
        {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 20000;
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();
            httpWebResponse.Close();
            streamReader.Close();
            return responseContent;
        }

        public static string Get3(string url)
        {
            WebClient wc = new WebClient();
            Encoding enc = Encoding.GetEncoding("UTF-8");
            Byte[] pageData = wc.DownloadData(url);
            string res = enc.GetString(pageData);
            return res;
        }
    }
}
