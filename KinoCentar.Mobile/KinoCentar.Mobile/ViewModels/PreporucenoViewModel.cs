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
    public class PreporucenoViewModel : BaseListViewModel
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);

        public ObservableCollection<ProjekcijaModel> ProjekcijeList { get; set; } = new ObservableCollection<ProjekcijaModel>();

        public PreporucenoViewModel()
        {
            Title = "Preporučene projekcije";
        }

        public async Task Init()
        {
            var response = projekcijeService.GetActionResponse("RecommendedList", Global.PrijavljeniKorisnik?.KorisnickoIme).Handle();
            if (response.IsSuccessStatusCode)
            {
                var projekcije = response.GetResponseResult<List<ProjekcijaModel>>();
                ProjekcijeList.Clear();
                foreach (var projekcija in projekcije)
                {
                    ProjekcijeList.Add(projekcija);
                }
                IsEmptyList = !ProjekcijeList.Any();
            }
        }
    }
}
