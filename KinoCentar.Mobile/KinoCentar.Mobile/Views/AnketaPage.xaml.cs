using KinoCentar.Mobile.ViewModels;
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
    public partial class AnketaPage : ContentPage
    {
        private AnketaViewModel model = null;

        public AnketaPage()
        {
            InitializeComponent();
            BindingContext = model = new AnketaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

            isEmptyList.IsVisible = model.IsEmptyList;
        }
    }
}