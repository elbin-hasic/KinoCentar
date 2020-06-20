using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KinoCentar.Shared.Extensions
{
    public static class HttpResponseMessageExtension
    {
        public static string HandleResponseMessage(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var detailMsg = response.ReasonPhrase;
                try
                {
                    var jsonResult = response.Content.ReadAsStringAsync().Result;
                    if (jsonResult != null && jsonResult.GetType() == typeof(string))
                    {
                        detailMsg = jsonResult;
                    }
                }
                catch
                { }

                return $"Error Code: { response.StatusCode }; Message: { detailMsg }";
            }

            return null;
        }

        public static T GetResponseResult<T>(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonObject.Result);
            }
            else
            {
                return default(T);
            }
        }
    }
}
