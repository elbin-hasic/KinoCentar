using KinoCentar.Mobile.ViewModels;
using KinoCentar.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KinoCentar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijePage : ContentPage
    {
        private RezervacijeViewModel model = null;

        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void rezervacijeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RezervacijaModel;
            if (item != null)
            {
                await Navigation.PushAsync(new ProjekcijePrikazPage(item.Projekcija));
            }
        }
    }
}