using KinoCentar.Mobile.Extensions;
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
        private ICommand InitCommand { get; set; }

        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.ApiAddress, Global.RezervacijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper dojmoviService = new WebAPIHelper(Global.ApiAddress, Global.DojmoviRoute, Global.PrijavljeniKorisnik);

        public ICommand RezervisiCommand { get; set; }
        public ICommand OtkaziRezervacijuCommand { get; set; }
        public ICommand AddDojamCommand { get; set; }

        public ProjekcijaModel Projekcija { get; set; }

        public RezervacijaModel Rezervacija { get; set; }

        public bool RezervacijaExists { get; set; }

        public DojamModel Dojam { get; set; }

        public bool DojamExists { get; set; }

        public ProjekcijePrikazViewModel(ProjekcijaModel projekcija)
        {
            Projekcija = projekcija;
            Title = "Projekcija: " + projekcija?.FilmNaslov;
            Init();

            RezervisiCommand = new Command(async () => await Rezervisi());
            OtkaziRezervacijuCommand = new Command(async () => await OtkaziRezervaciju());
            AddDojamCommand = new Command(async () => await AddDojam());
        }

        private void Init()
        {
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

            RezervacijaExists = (Rezervacija != null && Rezervacija.Id > 0);
            DojamExists = (Dojam != null && Dojam.Id > 0);
        }

        private async Task Rezervisi()
        {
            Rezervacija.KorisnikId = Global.PrijavljeniKorisnik.Id;
            Rezervacija.ProjekcijaId = Projekcija.Id;
            Rezervacija.Cijena = Projekcija.Cijena;
            Rezervacija.Datum = DateTime.Now;

            var response = rezervacijeService.PostResponse(Rezervacija).Handle();
            if (response.IsSuccessStatusCode)
            {
                Rezervacija = response.GetResponseResult<RezervacijaModel>();
                RezervacijaExists = (Rezervacija != null && Rezervacija.Id > 0);
                await Application.Current.MainPage.DisplayAlert("Uspješno ste dodali rezervaciju.", "Poruka o uspjehu", "OK");
            }
        }

        private async Task OtkaziRezervaciju()
        {
            var response = rezervacijeService.PutActionResponse("disable", Rezervacija.Id).Handle();
            if (response.IsSuccessStatusCode)
            {
                Rezervacija = new RezervacijaModel();
                RezervacijaExists = false;
                await Application.Current.MainPage.DisplayAlert("Uspješno ste otkazali rezervaciju.", "Poruka o uspjehu", "OK");
            }
        }

        private async Task AddDojam()
        {
            Dojam.KorisnikId = Global.PrijavljeniKorisnik.Id;
            Dojam.ProjekcijaId = Projekcija.Id;
            Dojam.Datum = DateTime.Now;

            var response = dojmoviService.PostResponse(Dojam).Handle();
            if (response.IsSuccessStatusCode)
            {
                Dojam = response.GetResponseResult<DojamModel>();
                DojamExists = (Dojam != null && Dojam.Id > 0);
                await Application.Current.MainPage.DisplayAlert("Uspješno ste dodali dojam.", "Poruka o uspjehu", "OK");
            }
        }
    }
}
