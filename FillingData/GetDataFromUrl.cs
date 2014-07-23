namespace Testing.FillingData
{
    using System.IO;
    using System.Net;
    using Newtonsoft.Json.Linq;

    public static partial class FillingDataFromCoursera
    {
        // Переделать методы получения JSON (оптимизировать фиксы)
        private static string GetDataFromSomeUrl(string url)
        {
            var result = string.Empty;
            var myRequest = (HttpWebRequest)WebRequest.Create(url);
            /*myRequest.Proxy.Credentials = new NetworkCredential("DavletovA", "Tgg567876c", "RUSSIA");
            myRequest.Proxy = WebRequest.DefaultWebProxy;*/

            var myResponse = (HttpWebResponse)myRequest.GetResponse();
            var responseStream = myResponse.GetResponseStream();

            if (responseStream != null)
            {
                using (var sr = new StreamReader(responseStream))
                {
                    var str = sr.ReadToEnd();
                    var parsed = JObject.Parse(str);
                    result = parsed["elements"].ToString();
                }
            }

            return result;
        }
        private static string GetDataFromSomeUrl2(string url)
        {
            var result = string.Empty;
            var myRequest = (HttpWebRequest)WebRequest.Create(url);
            /*myRequest.Proxy.Credentials = new NetworkCredential("DavletovA", "Tgg567876c", "RUSSIA");
            myRequest.Proxy = WebRequest.DefaultWebProxy;*/

            var myResponse = (HttpWebResponse)myRequest.GetResponse();
            var responseStream = myResponse.GetResponseStream();

            if (responseStream != null)
            {
                using (var sr = new StreamReader(responseStream))
                {
                    result = sr.ReadToEnd();

                    var ind = result.IndexOf(",\"linked\":{");
                    result = result.Substring(0, ind);

                    result = result.Replace("{\"elements\":", "").Replace("\"links\":{", "");
                    var tmp = result.LastIndexOf('}');
                    result = result.Remove(tmp, 1);
                    result = result.Replace("}}", "}");
                }
            }

            return result;
        }
    }
}
