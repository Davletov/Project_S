namespace FiilingData.FillingCourseraData
{
    using System;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json.Linq;

    // Переделать методы получения JSON (оптимизировать фиксы)
    public static partial class FillingDataFromCoursera
    {
        // 1 метод для получения JSON c Coursera Api без параметра include in URL
        private static string GetDataFromSomeUrl(string url)
        {
            try
            {
                var result = string.Empty;
                var myRequest = (HttpWebRequest) WebRequest.Create(url);
                myRequest.Proxy.Credentials = new NetworkCredential("DavletovA", "Tgg567876d", "RUSSIA");
                myRequest.Proxy = WebRequest.DefaultWebProxy;

                var myResponse = (HttpWebResponse) myRequest.GetResponse();
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
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }
        }

        // 1 метод для получения JSON c Coursera Api c параметром include in URL
        private static string GetDataFromSomeUrl2(string url)
        {
            try
            {
                var result = string.Empty;
                var myRequest = (HttpWebRequest) WebRequest.Create(url);
                myRequest.Proxy.Credentials = new NetworkCredential("DavletovA", "Tgg567876d", "RUSSIA");
                myRequest.Proxy = WebRequest.DefaultWebProxy;

                var myResponse = (HttpWebResponse) myRequest.GetResponse();
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
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }
        }
    }
}
