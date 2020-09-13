using KinoCentar.Mobile.Extensions;
using KinoCentar.Mobile.Models;
using KinoCentar.Mobile.Models.Validations;
using KinoCentar.Mobile.Views;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KinoCentar.Mobile.ViewModels
{
    public class UrediProfilViewModel : BaseViewModel
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute, Global.PrijavljeniKorisnik);

        public ICommand SnimiCommand { get; set; }

        KorisnikModel korisnik = new KorisnikModel()
        {
            Ime = ".",
            Prezime = ".",
            Email = ".",
            KorisnickoIme = "."
        };

        public KorisnikModel Korisnik
        {
            get { return korisnik; }
            set { SetProperty(ref korisnik, value); }
        }

        byte[] korisnikUploadSlika = null;
        public byte[] KorisnikUploadSlika
        {
            get { return korisnikUploadSlika; }
            set { SetProperty(ref korisnikUploadSlika, value); }
        }

        KorisnikValidModel korisnikValid = new KorisnikValidModel();
        public KorisnikValidModel KorisnikValid
        {
            get { return korisnikValid; }
            set { SetProperty(ref korisnikValid, value); }
        }

        public UrediProfilViewModel()
        {
            SnimiCommand = new Command(async () => await Snmi());
        }

        public async Task Init()
        {
            var response = korisniciService.GetResponse(Global.PrijavljeniKorisnik?.Id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                Korisnik = response.GetResponseResult<KorisnikModel>();
            }
            Title = "Korisnik: " + Korisnik?.ImePrezime;
        }

        private async Task Snmi()
        {
            IsBusy = true;

            if (Validate())
            {
                var password = Korisnik.Lozinka;

                Korisnik.Lozinka = string.Empty;

                if (!string.IsNullOrEmpty(password))
                {
                    Korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                    Korisnik.LozinkaHash = UIHelper.GenerateHash(Korisnik.LozinkaSalt, password);
                }

                if (KorisnikUploadSlika != null)
                {
                    Korisnik.Slika = KorisnikUploadSlika;
                    Korisnik.SlikaThumb = KorisnikUploadSlika;
                }                

                var response = korisniciService.PutResponse(Korisnik.Id, Korisnik).Handle();
                if (response.IsSuccessStatusCode)
                {
                    Korisnik.Lozinka = !string.IsNullOrEmpty(password) ? password : Global.PrijavljeniKorisnik.Lozinka;
                    Global.PrijavljeniKorisnik = Korisnik;
                    korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute, Global.PrijavljeniKorisnik);
                    await Application.Current.MainPage.DisplayAlert("Uspješno ste uredili profil.", "Poruka o uspjehu", "OK");
                    Application.Current.MainPage = new MainPage();
                }
            }            

            IsBusy = false;
        }

        #region Validation

        private bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Korisnik.Ime))
            {
                KorisnikValid.ImeReqNotValid = true;
                isValid = false;
            }
            else
            {
                KorisnikValid.ImeReqNotValid = false;
            }

            if (string.IsNullOrEmpty(Korisnik.Prezime))
            {
                KorisnikValid.PrezimeReqNotValid = true;
                isValid = false;
            }
            else
            {
                KorisnikValid.PrezimeReqNotValid = false;
            }

            if (string.IsNullOrEmpty(Korisnik.Email))
            {
                KorisnikValid.EmailReqNotValid = true;
                isValid = false;
            }
            else
            {
                KorisnikValid.EmailReqNotValid = false;

                try
                {
                    MailAddress mail = new MailAddress(Korisnik.Email);
                    KorisnikValid.EmailErrNotValid = false;
                }
                catch (FormatException)
                {
                    KorisnikValid.EmailErrNotValid = true;
                    isValid = false;
                }
            }

            if (!string.IsNullOrEmpty(Korisnik.Lozinka) && 
                (Korisnik.Lozinka.Length < 6 || !Korisnik.Lozinka.Any(char.IsDigit) || !Korisnik.Lozinka.Any(char.IsLetter)))
            {
                KorisnikValid.LozinkaErrNotValid = true;
                isValid = false;
            }
            else
            {
                KorisnikValid.LozinkaErrNotValid = false;
            }

            KorisnikValid.IsValid = isValid;

            return isValid;
        }

        #endregion
    }
}
