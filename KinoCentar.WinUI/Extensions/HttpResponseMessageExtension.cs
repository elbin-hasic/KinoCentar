using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoCentar.WinUI.Extensions
{
    public static class HttpResponseMessageExtension
    {
        public static HttpResponseMessage Handle(this HttpResponseMessage response)
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
                {}
                
                MessageBox.Show("Error Code: " + response.StatusCode + "; Message: " + detailMsg);
            }

            return response;
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
