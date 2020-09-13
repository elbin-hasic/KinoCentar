using KinoCentar.Mobile.Extensions;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KinoCentar.Mobile.ViewModels
{
    public class AnketaViewModel : BaseListViewModel
    {
        private WebAPIHelper anketaService = new WebAPIHelper(Global.ApiAddress, Global.AnketeRoute, Global.PrijavljeniKorisnik);

        public ICommand AnketaOdgCommand { get; set; }

        AnketaModel _anketa = null;
        public AnketaModel Anketa
        {
            get { return _anketa; }
            set { SetProperty(ref _anketa, value); }
        }

        AnketaOdgovorModel selectedOdgovor;
        public AnketaOdgovorModel SelectedOdgovor
        {
            get { return selectedOdgovor; }
            set
            {
                if (selectedOdgovor != value)
                {
                    selectedOdgovor = value;
                    OnPropertyChanged();
                }
            }
        }

        bool korisnikOdgovorExists = false;
        public bool KorisnikOdgovorExists
        {
            get { return korisnikOdgovorExists; }
            set { SetProperty(ref korisnikOdgovorExists, value); }
        }

        bool korisnikOdgovorNotExists = false;
        public bool KorisnikOdgovorNotExists
        {
            get { return korisnikOdgovorNotExists; }
            set { SetProperty(ref korisnikOdgovorNotExists, value); }
        }

        public AnketaViewModel()
        {
            Title = "Aktivna anketa";

            AnketaOdgCommand = new Command(async () => await SendAnketaOdgovor());
        }

        public async Task Init()
        {
            var response = anketaService.GetActionResponse("Active", Global.PrijavljeniKorisnik.Id.ToString()).HandleNotFound();
            if (response.IsSuccessStatusCode)
            {
                Anketa = response.GetResponseResult<AnketaModel>();

                if (Anketa != null && Anketa.Odgovori.Any())
                {
                    SelectedOdgovor = Anketa.Odgovori[0];
                }
            }

            IsEmptyList = (Anketa == null);

            RefreshPage();
        }

        private async Task SendAnketaOdgovor()
        {
            IsBusy = true;

            var korisnikOdgovor = new AnketaOdgovorKorisnikDodjelaModel();
            korisnikOdgovor.KorisnikId = Global.PrijavljeniKorisnik.Id;
            korisnikOdgovor.AnketaOdgovorId = SelectedOdgovor.Id;
            korisnikOdgovor.Datum = DateTime.Now;

            var response = anketaService.PostActionResponse("UserAnswer", korisnikOdgovor).Handle();
            if (response.IsSuccessStatusCode)
            {
                Anketa = response.GetResponseResult<AnketaModel>();
                await Application.Current.MainPage.DisplayAlert("Uspješno ste dodali odgovor na anketu.", "Poruka o uspjehu", "OK");
                RefreshPage();
            }

            IsBusy = false;
        }

        private void RefreshPage()
        {
            if (!IsEmptyList)
            {
                KorisnikOdgovorExists = (Anketa != null && Anketa.KorisnikAnketaOdgovorId != null && Anketa.KorisnikAnketaOdgovorId.Value > 0);
                KorisnikOdgovorNotExists = !KorisnikOdgovorExists;
            }            
        }
    }
}
