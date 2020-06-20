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
    public partial class ProjekcijePage : ContentPage
    {
        private ProjekcijeViewModel model = null;

        public ProjekcijePage()
        {
            InitializeComponent();
            BindingContext = model = new ProjekcijeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void projekcijeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ProjekcijaModel;
            if (item != null)
            {
                await Application.Current.MainPage.DisplayAlert($"[{item.Id}] {item.FilmNaslov}", "ProjekcijaInfo", "OK");
            }            
        }
    }
}