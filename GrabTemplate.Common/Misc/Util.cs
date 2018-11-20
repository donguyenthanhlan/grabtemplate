using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GrabTemplate.Common.Misc
{
    public static class Util
    {
        public static string GetShortenLink(string url, string source, int id)
        {
            var response = new HttpClient().GetAsync(string.Format(Constant.ShortenLink.Url, url, source, id));
            response.Wait();
            if (response.Result.IsSuccessStatusCode)
            {
                var jsonResponse = response.Result.Content.ReadAsStringAsync();
                if (JObject.Parse(jsonResponse.Result)["status"].ToString() == "success")
                {
                    return JObject.Parse(jsonResponse.Result)["shortenedUrl"].ToString();
                }
            }
            return null;
        }
    }
}
