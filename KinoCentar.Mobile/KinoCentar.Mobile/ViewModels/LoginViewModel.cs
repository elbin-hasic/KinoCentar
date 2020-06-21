using KinoCentar.Mobile.Views;
using KinoCentar.Shared;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KinoCentar.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);

        public ICommand LoginCommand { get; set; }

        public ICommand RegistracijaCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegistracijaCommand = new Command(async () => await RegistracijaRedirect());
        }

        // string _username = string.Empty;
        string _username = "ehasic";
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        // string _password = string.Empty;
        string _password = "test123";
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        async Task Login()
        {
            IsBusy = true;

            try
            {
                HttpResponseMessage response = korisniciService.GetActionResponse("GetByUserName", Username, "true");
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    await Application.Current.MainPage.DisplayAlert(Messages.msg_err, Messages.login_user_err, "OK");
                }
                else if (response.IsSuccessStatusCode)
                {
                    KorisnikModel korisnik = response.GetResponseResult<KorisnikModel>();
                    if (korisnik.LozinkaHash == UIHelper.GenerateHash(korisnik.LozinkaSalt, Password))
                    {
                        korisnik.Lozinka = Password;
                        Global.PrijavljeniKorisnik = korisnik;
                        Application.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert(Messages.msg_err, Messages.login_pass_err, "OK");
                        Password = string.Empty;
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(Messages.msg_err, Messages.login_err, "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(Messages.msg_err, ex.Message, "OK");
            }

            IsBusy = false;
        }

        async Task RegistracijaRedirect()
        {
            IsBusy = true;

            Application.Current.MainPage = new RegistracijaPage();

            IsBusy = false;
        }
    }
}
