using KinoCentar.Mobile.Extensions;
using KinoCentar.Mobile.Models.Validations;
using KinoCentar.Mobile.Views;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KinoCentar.Mobile.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);

        public ICommand RegistracijaCommand { get; set; }

        KorisnikModel korisnik = new KorisnikModel();
        public KorisnikModel Korisnik
        {
            get { return korisnik; }
            set { SetProperty(ref korisnik, value); }
        }

        KorisnikValidModel korisnikValid = new KorisnikValidModel();
        public KorisnikValidModel KorisnikValid
        {
            get { return korisnikValid; }
            set { SetProperty(ref korisnikValid, value); }
        }

        public RegistracijaViewModel()
        {
            RegistracijaCommand = new Command(async () => await Registracija());
        }

        async Task Registracija()
        {
            IsBusy = true;

            if (Validate())
            {
                var password = Korisnik.Lozinka;

                Korisnik.Lozinka = string.Empty;

                Korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                Korisnik.LozinkaHash = UIHelper.GenerateHash(Korisnik.LozinkaSalt, password);

                var response = korisniciService.PostActionResponse("Registracija", Korisnik).Handle();
                if (response.IsSuccessStatusCode)
                {
                    Korisnik = response.GetResponseResult<KorisnikModel>();
                    await Application.Current.MainPage.DisplayAlert("Uspješno ste završili registraciju.", "Poruka o uspjehu", "OK");

                    if (Korisnik.Id > 0)
                    {
                        Korisnik.Lozinka = password;
                        Global.PrijavljeniKorisnik = Korisnik;
                        Application.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        Application.Current.MainPage = new LoginPage();
                    }
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

            if (string.IsNullOrEmpty(Korisnik.KorisnickoIme))
            {
                KorisnikValid.KorisnickoImeReqNotValid = true;
                isValid = false;
            }
            else
            {
                KorisnikValid.KorisnickoImeReqNotValid = false;

                if (Korisnik.KorisnickoIme.Length < 3)
                {
                    KorisnikValid.KorisnickoImeErrNotValid = true;
                    isValid = false;
                }
                else
                {                    
                    KorisnikValid.KorisnickoImeErrNotValid = false;
                }
            }

            if (string.IsNullOrEmpty(Korisnik.Lozinka))
            {
                KorisnikValid.LozinkaReqNotValid = true;
                isValid = false;
            }
            else
            {
                KorisnikValid.LozinkaReqNotValid = false;

                if (Korisnik.Lozinka.Length < 6 || !Korisnik.Lozinka.Any(char.IsDigit) || !Korisnik.Lozinka.Any(char.IsLetter))
                {
                    KorisnikValid.LozinkaErrNotValid = true;
                    isValid = false;
                }
                else
                {                    
                    KorisnikValid.LozinkaErrNotValid = false;
                }
            }

            KorisnikValid.IsValid = isValid;

            return isValid;
        }

        #endregion
    }
}
