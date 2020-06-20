using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KinoCentar.Mobile.Services;
using KinoCentar.Mobile.Views;

namespace KinoCentar.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            // MainPage = new MainPage();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
