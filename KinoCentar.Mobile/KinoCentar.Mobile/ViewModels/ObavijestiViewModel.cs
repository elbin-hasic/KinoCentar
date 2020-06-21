using KinoCentar.Mobile.Extensions;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KinoCentar.Mobile.ViewModels
{
    public class ObavijestiViewModel : BaseListViewModel
    {
        private WebAPIHelper obavijestiService = new WebAPIHelper(Global.ApiAddress, Global.ObavijestiRoute, Global.PrijavljeniKorisnik);

        public ObservableCollection<ObavijestModel> ObavijestiList { get; set; } = new ObservableCollection<ObavijestModel>();

        public ObavijestiViewModel()
        {
            Title = "Obavijesti";
        }

        public async Task Init()
        {
            var response = obavijestiService.GetResponse().Handle();
            if (response.IsSuccessStatusCode)
            {
                var obavijesti = response.GetResponseResult<List<ObavijestModel>>();
                ObavijestiList.Clear();                
                foreach (var obavijest in obavijesti)
                {
                    ObavijestiList.Add(obavijest);
                }
                IsEmptyList = !ObavijestiList.Any();
            }
        }
    }
}
