using KinoCentar.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KinoCentar.Shared.Util
{
    public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse(string parameter = "")
        {
            return client.GetAsync(route + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string p1 = "", string p2 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + p1 + "/" + p2).Result;
        }

        public HttpResponseMessage GetActionSearchResponse(string action, string p1 = "*", string p2 = "*")
        {
            if (string.IsNullOrEmpty(p1))
            {
                p1 = "*";
            }
            if (string.IsNullOrEmpty(p2))
            {
                p2 = "*";
            }
            return client.GetAsync(route + "/" + action + "/" + p1 + "/" + p2).Result;
        }

        public HttpResponseMessage PostResponse(Object newObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }

        public HttpResponseMessage PutActionResponse(string action, int id)
        {
            return client.PutAsync(route + "/" + action + "/" + id, null).Result;
        }

        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }
    }
}
