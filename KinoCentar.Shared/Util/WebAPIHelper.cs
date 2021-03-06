﻿using KinoCentar.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KinoCentar.Shared.Util
{
    public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebAPIHelper(string uri, string route, string username = null, string password = null)
        {
            this.route = route;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));
                client = new HttpClient()
                {
                    DefaultRequestHeaders = { Authorization = authValue }
                };
            }
            else
            {
                client = new HttpClient();
            }
            
            client.BaseAddress = new Uri(uri);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public WebAPIHelper(string uri, string route, KorisnikModel korisnik) : this(uri, route, korisnik?.KorisnickoIme, korisnik?.Lozinka)
        {
            
        }

        #region GET

        public HttpResponseMessage GetResponse(string parameter = "")
        {
            return GetResponseAsync(parameter).Result;
        }

        public Task<HttpResponseMessage> GetResponseAsync(string parameter = "")
        {
            return client.GetAsync(route + "/" + parameter);
        }

        public HttpResponseMessage GetActionResponse(string action, params string[] parameters)
        {
            return GetActionResponseAsync(action, parameters).Result;
        }

        public Task<HttpResponseMessage> GetActionResponseAsync(string action, params string[] parameters)
        {
            string actionParameters = string.Empty;

            foreach (var p in parameters)
            {
                actionParameters += "/" + p;
            }

            return client.GetAsync(route + "/" + action + actionParameters);
        }

        public HttpResponseMessage GetActionSearchResponse(string action, string p1 = "*", string p2 = "*", string p3 = "")
        {
            return GetActionSearchResponseAsync(action, p1, p2, p3).Result;
        }

        public Task<HttpResponseMessage> GetActionSearchResponseAsync(string action, string p1 = "*", string p2 = "*", string p3 = "")
        {
            if (string.IsNullOrEmpty(p1))
            {
                p1 = "*";
            }
            if (string.IsNullOrEmpty(p2))
            {
                p2 = "*";
            }

            return client.GetAsync(route + "/" + action + "/" + p1 + "/" + p2 + "/" + p3);
        }

        public HttpResponseMessage GetActionResponse(string action, Object newObject)
        {
            return GetActionResponseAsync(action, newObject).Result;
        }

        public Task<HttpResponseMessage> GetActionResponseAsync(string action, Object newObject)
        {
            string queryString = GetQueryString(newObject);
            if (!string.IsNullOrEmpty(queryString))
            {
                return client.GetAsync(route + "/" + action + "?" + queryString);
            }
            else
            {
                return client.GetAsync(route + "/" + action);
            }
        }

        private string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }

        #endregion

        #region POST

        public HttpResponseMessage PostResponse(Object newObject)
        {
            return PostResponseAsync(newObject).Result;
        }

        public Task<HttpResponseMessage> PostResponseAsync(Object newObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject);
        }

        public HttpResponseMessage PostActionResponse(string action, string parameter = "")
        {
            return PostActionResponseAsync(action, parameter).Result;
        }

        public Task<HttpResponseMessage> PostActionResponseAsync(string action, string parameter = "")
        {
            return client.PostAsync(route + "/" + action + "/" + parameter, null);
        }

        public HttpResponseMessage PostActionResponse(string action, params string[] parameters)
        {
            return PostActionResponseAsync(action, parameters).Result;
        }

        public Task<HttpResponseMessage> PostActionResponseAsync(string action, params string[] parameters)
        {
            string actionParameters = string.Empty;

            foreach (var p in parameters)
            {
                actionParameters += "/" + p;
            }

            return client.PostAsync(route + "/" + action + actionParameters, null);
        }

        public HttpResponseMessage PostActionResponse(string action, Object newObject)
        {
            return PostActionResponseAsync(action, newObject).Result;
        }

        public Task<HttpResponseMessage> PostActionResponseAsync(string action, Object newObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");
            return client.PostAsync(route + "/" + action, jsonObject);
        }

        #endregion

        #region PUT

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            return PutResponseAsync(id, existingObject).Result;
        }

        public Task<HttpResponseMessage> PutResponseAsync(int id, Object existingObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject);
        }

        public HttpResponseMessage PutActionResponse(string action, int id)
        {
            return PutActionResponseAsync(action, id).Result;
        }

        public Task<HttpResponseMessage> PutActionResponseAsync(string action, int id)
        {
            return client.PutAsync(route + "/" + action + "/" + id, null);
        }

        public HttpResponseMessage PutActionResponse(string action, int id1, int id2)
        {
            return PutActionResponseAsync(action, id1, id2).Result;
        }

        public Task<HttpResponseMessage> PutActionResponseAsync(string action, int id1, int id2)
        {
            return client.PutAsync(route + "/" + action + "/" + id1 + "/" + id2, null);
        }

        public HttpResponseMessage PutActionResponse(string action, Object existingObject, int id)
        {
            return PutActionResponseAsync(action, existingObject, id).Result;
        }

        public Task<HttpResponseMessage> PutActionResponseAsync(string action, Object existingObject, int id)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + action + "/" + id, jsonObject);
        }

        #endregion

        #region DELETE

        public HttpResponseMessage DeleteResponse(int id)
        {
            return DeleteResponseAsync(id).Result;
        }

        public Task<HttpResponseMessage> DeleteResponseAsync(int id)
        {
            return client.DeleteAsync(route + "/" + id);
        }

        #endregion
    }
}
