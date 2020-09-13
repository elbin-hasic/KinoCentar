using KinoCentar.Mobile.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KinoCentar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediProfilPage : ContentPage
    {
        private UrediProfilViewModel model = null;
        private MediaFile _mediaFile;

        public UrediProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new UrediProfilViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ButtonIzaberiSliku_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Profilna slika", "Odabir fotografije nije dozvoljen", "OK");
                return;
            }

            _mediaFile = await CrossMedia.Current.PickPhotoAsync();
            if (_mediaFile == null)
            {
                return;
            }

            KorisnikSlikaPath.Text = _mediaFile.Path;

            model.KorisnikUploadSlika = ConvertStreamToByteArray(_mediaFile.GetStream());
        }

        private static byte[] ConvertStreamToByteArray(Stream imgStream)
        {
            byte[] result;
            using (var streamReader = new MemoryStream())
            {
                imgStream.CopyTo(streamReader);
                result = streamReader.ToArray();
            }
            return result;
        }
    }
}