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
    public class RezervacijeViewModel : BaseListViewModel
    {
        private ICommand InitCommand { get; set; }

        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.ApiAddress, Global.RezervacijeRoute, Global.PrijavljeniKorisnik);

        public ObservableCollection<RezervacijaModel> RezervacijeList { get; set; } = new ObservableCollection<RezervacijaModel>();

        public RezervacijeViewModel()
        {
            Title = "Rezervacije";
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            var response = rezervacijeService.GetActionResponse("GetByUserName", Global.PrijavljeniKorisnik?.KorisnickoIme).Handle();
            if (response.IsSuccessStatusCode)
            {
                var rezervacije = response.GetResponseResult<List<RezervacijaModel>>();
                HasItems = rezervacije.Any();

                RezervacijeList.Clear();
                foreach (var rezervacija in rezervacije)
                {
                    RezervacijeList.Add(rezervacija);
                }
            }
        }
    }
}
