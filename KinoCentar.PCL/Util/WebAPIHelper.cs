using KinoCentar.PCL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KinoCentar.PCL.Util
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

        public HttpResponseMessage PostResponse(Object newObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject).Result;
        }

        public HttpResponseMessage RawActionResponse(string action)
        {
            return client.GetAsync(this.route + "/" + action).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }

        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }
    }
}
