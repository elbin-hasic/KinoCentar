using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KinoCentar.API.Exceptions
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException()
        {

        }

        public HttpResponseException(HttpResponseMessage message)
        {
            Status = (int)message.StatusCode;
            Value = message.Content;
        }

        public int Status { get; set; } = 500;

        public object Value { get; set; }
    }
}
