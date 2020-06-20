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

namespace KinoCentar.Mobile.ViewModels
{
    public class ProjekcijeViewModel : BaseViewModel
    {
        private ICommand InitCommand { get; set; }

        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);

        public ProjekcijeViewModel()
        {
            Title = "Projekcije";
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<ProjekcijaModel> ProjekcijeList { get; set; } = new ObservableCollection<ProjekcijaModel>();

        public async Task Init()
        {
            // var response = projekcijeService.GetActionResponse("SearchByName", name).Handle();
            var response = await projekcijeService.GetResponseAsync();
            response.Handle();
            if (response.IsSuccessStatusCode)
            {
                var projekcije = response.GetResponseResult<List<ProjekcijaModel>>();
                ProjekcijeList.Clear();
                foreach (var projekcija in projekcije)
                {
                    ProjekcijeList.Add(projekcija);
                }
            }            
        }
    }
}
