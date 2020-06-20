using KinoCentar.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace KinoCentar.Mobile.Extensions
{
    public static class HttpResponseMessageExtension
    {
        public static HttpResponseMessage Handle(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var msg = Shared.Extensions.HttpResponseMessageExtension.HandleResponseMessage(response);
                Application.Current.MainPage.DisplayAlert(msg, Messages.login_err, "OK");
            }

            return response;
        }
    }
}
