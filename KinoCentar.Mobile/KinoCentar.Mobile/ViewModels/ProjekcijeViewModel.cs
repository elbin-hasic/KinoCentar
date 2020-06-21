using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using KinoCentar.Shared.Extensions;
using KinoCentar.Mobile.Extensions;
using System.Linq;

namespace KinoCentar.Mobile.ViewModels
{
    public class ProjekcijeViewModel : BaseListViewModel
    {
        public ICommand InitCommand { get; set; }

        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);

        public ObservableCollection<ProjekcijaModel> ProjekcijeList { get; set; } = new ObservableCollection<ProjekcijaModel>();

        public ProjekcijeViewModel()
        {
            Title = "Projekcije";
        }

        public async Task Init()
        {
            var response = projekcijeService.GetActionResponse("ActiveList", "").Handle();
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
