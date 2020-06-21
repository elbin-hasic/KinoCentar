using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using KinoCentar.Mobile.Models;

namespace KinoCentar.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Pocetna, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Pocetna:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.Projekcije:
                        MenuPages.Add(id, new NavigationPage(new ProjekcijePage()));
                        break;
                    case (int)MenuItemType.Preporuceno:
                        MenuPages.Add(id, new NavigationPage(new PreporucenoPage()));
                        break;
                    case (int)MenuItemType.Rezervacije:
                        MenuPages.Add(id, new NavigationPage(new RezervacijePage()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage(new ObavijestiPage()));
                        break;
                    //
                    case (int)MenuItemType.UrediProfil:
                        MenuPages.Add(id, new NavigationPage(new UrediProfilPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}