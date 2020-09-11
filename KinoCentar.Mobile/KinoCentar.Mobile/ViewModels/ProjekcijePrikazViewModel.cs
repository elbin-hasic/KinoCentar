using KinoCentar.Mobile.Extensions;
using KinoCentar.Mobile.Models.Validations;
using KinoCentar.Mobile.Views;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KinoCentar.Mobile.ViewModels
{
    public class ProjekcijePrikazViewModel : BaseViewModel
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.ApiAddress, Global.RezervacijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper dojmoviService = new WebAPIHelper(Global.ApiAddress, Global.DojmoviRoute, Global.PrijavljeniKorisnik);

        public ICommand RezervisiCommand { get; set; }
        public ICommand OtkaziRezervacijuCommand { get; set; }
        public ICommand AddDojamCommand { get; set; }

        public ProjekcijaModel Projekcija { get; set; }

        RezervacijaModel rezervacija = null;
        public RezervacijaModel Rezervacija
        {
            get { return rezervacija; }
            set { SetProperty(ref rezervacija, value); }
        }

        RezervacijaValidModel rezervacijaValid = new RezervacijaValidModel();
        public RezervacijaValidModel RezervacijaValid
        {
            get { return rezervacijaValid; }
            set { SetProperty(ref rezervacijaValid, value); }
        }

        DojamModel dojam = null;
        public DojamModel Dojam
        {
            get { return dojam; }
            set { SetProperty(ref dojam, value); }
        }

        DojamValidModel dojamValid = new DojamValidModel();
        public DojamValidModel DojamValid
        {
            get { return dojamValid; }
            set { SetProperty(ref dojamValid, value); }
        }

        bool rezervacijaExists = false;
        public bool RezervacijaExists
        {
            get { return rezervacijaExists; }
            set { SetProperty(ref rezervacijaExists, value); }
        }

        bool rezervacijaNotExists = true;
        public bool RezervacijaNotExists
        {
            get { return rezervacijaNotExists; }
            set { SetProperty(ref rezervacijaNotExists, value); }
        }

        bool dojamNotExists = true;
        public bool DojamNotExists
        {
            get { return dojamNotExists; }
            set { SetProperty(ref dojamNotExists, value); }
        }

        bool dojamExists = false;
        public bool DojamExists
        {
            get { return dojamExists; }
            set { SetProperty(ref dojamExists, value); }
        }

        public ProjekcijePrikazViewModel(ProjekcijaModel projekcija)
        {
            Projekcija = projekcija;
            Title = "Projekcija: " + projekcija?.FilmNaslov;

            RezervisiCommand = new Command(async () => await Rezervisi());
            OtkaziRezervacijuCommand = new Command(async () => await OtkaziRezervaciju());
            AddDojamCommand = new Command(async () => await AddDojam());
        }

        public async Task Init()
        {
            // Postaviti projekciju kao pregledanu 
            projekcijeService.PutActionResponse("Visit", Projekcija.Id, Global.PrijavljeniKorisnik.Id);

            var rezervacijeResponse = rezervacijeService.GetActionResponse("GetByUserProjection", Projekcija.Id.ToString(), Global.PrijavljeniKorisnik?.KorisnickoIme).HandleNotFound();
            if (rezervacijeResponse.IsSuccessStatusCode)
            {
                Rezervacija = rezervacijeResponse.GetResponseResult<RezervacijaModel>();
            }

            var dojmoviResponse = dojmoviService.GetActionResponse("GetByUserImpression", Projekcija.Id.ToString(), Global.PrijavljeniKorisnik?.KorisnickoIme).HandleNotFound();
            if (dojmoviResponse.IsSuccessStatusCode)
            {
                Dojam = dojmoviResponse.GetResponseResult<DojamModel>();
            }

            if (Rezervacija == null)
            {
                Rezervacija = new RezervacijaModel();
            }
            if (Dojam == null)
            {
                Dojam = new DojamModel();
            }

            RefreshPage();
        }

        private async Task Rezervisi()
        {
            IsBusy = true;

            if (ValidateRezervisi())
            {
                Rezervacija.KorisnikId = Global.PrijavljeniKorisnik.Id;
                //Rezervacija.ProjekcijaId = Projekcija.Id;
                Rezervacija.Cijena = Projekcija.Cijena;
                Rezervacija.Datum = DateTime.Now;

                var response = rezervacijeService.PostResponse(Rezervacija).Handle();
                if (response.IsSuccessStatusCode)
                {
                    Rezervacija = response.GetResponseResult<RezervacijaModel>();
                    await Application.Current.MainPage.DisplayAlert("Uspješno ste dodali rezervaciju.", "Poruka o uspjehu", "OK");
                    RefreshPage();
                }
            }            

            IsBusy = false;
        }

        private async Task OtkaziRezervaciju()
        {
            IsBusy = true;

            var response = rezervacijeService.PutActionResponse("Disable", Rezervacija.Id).Handle();
            if (response.IsSuccessStatusCode)
            {                
                await Application.Current.MainPage.DisplayAlert("Uspješno ste otkazali rezervaciju.", "Poruka o uspjehu", "OK");
                Rezervacija = new RezervacijaModel();
                RefreshPage();
            }

            IsBusy = false;
        }

        private async Task AddDojam()
        {
            IsBusy = true;

            if (ValidateAddDojam())
            {
                Dojam.KorisnikId = Global.PrijavljeniKorisnik.Id;
                Dojam.ProjekcijaId = Projekcija.Id;
                Dojam.Datum = DateTime.Now;

                var response = dojmoviService.PostResponse(Dojam).Handle();
                if (response.IsSuccessStatusCode)
                {
                    Dojam = response.GetResponseResult<DojamModel>();
                    await Application.Current.MainPage.DisplayAlert("Uspješno ste dodali dojam.", "Poruka o uspjehu", "OK");
                    RefreshPage();
                }
            }            

            IsBusy = false;
        }

        private void RefreshPage()
        {
            RezervacijaExists = (Rezervacija != null && Rezervacija.Id > 0);
            RezervacijaNotExists = !RezervacijaExists;
            DojamExists = (Dojam != null && Dojam.Id > 0);
            DojamNotExists = !DojamExists;
        }

        #region Validation

        private bool ValidateRezervisi()
        {
            bool isValid = true;

            if (Rezervacija.BrojSjedista < 1 || Rezervacija.BrojSjedista > Projekcija.Sala.BrojSjedista)
            {
                RezervacijaValid.BrojSjedistaErrNotValid = true;
                isValid = false;
            }
            else
            {
                RezervacijaValid.BrojSjedistaErrNotValid = false;
            }

            if (Rezervacija.DatumProjekcije.Date < Projekcija.VrijediOd.Date || Rezervacija.DatumProjekcije.Date > Projekcija.VrijediDo.Date)
            {
                RezervacijaValid.DatumProjekcijeErrNotValid = true;
                isValid = false;
            }
            else
            {
                RezervacijaValid.DatumProjekcijeErrNotValid = false;
            }

            RezervacijaValid.IsValid = isValid;

            return isValid;
        }

        private bool ValidateAddDojam()
        {
            bool isValid = true;

            if (Dojam.Ocjena < 1 || Dojam.Ocjena > 5)
            {
                DojamValid.OcjenaErrNotValid = true;
                isValid = false;
            }
            else
            {
                DojamValid.OcjenaErrNotValid = false;
            }

            DojamValid.IsValid = isValid;

            return isValid;
        }

        #endregion
    }
}
