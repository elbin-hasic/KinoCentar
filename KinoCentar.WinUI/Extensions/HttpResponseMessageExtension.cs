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
                var msg = Shared.Extensions.HttpResponseMessageExtension.HandleResponseMessage(response);
                MessageBox.Show(msg, Messages.msg_err, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return response;
        }
    }
}
