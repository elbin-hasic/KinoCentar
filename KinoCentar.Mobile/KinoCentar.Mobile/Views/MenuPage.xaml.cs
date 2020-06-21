using KinoCentar.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KinoCentar.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            korisnickoImeLabel.Text = Global.PrijavljeniKorisnik?.ImePrezime;

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Pocetna, Title="Početna" },
                new HomeMenuItem {Id = MenuItemType.Projekcije, Title="Projekcije" },
                new HomeMenuItem {Id = MenuItemType.Preporuceno, Title="Preporučeno" },
                new HomeMenuItem {Id = MenuItemType.Rezervacije, Title="Rezervacije" },
                new HomeMenuItem {Id = MenuItemType.Obavijesti, Title="Obavijesti" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await RootPage.NavigateFromMenu((int)MenuItemType.UrediProfil);
        }
    }
}