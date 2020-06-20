using KinoCentar.Mobile.ViewModels;
using KinoCentar.Shared.Models;
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
    public partial class ProjekcijePrikazPage : TabbedPage
    {
        private ProjekcijePrikazViewModel model = null;

        public ProjekcijePrikazPage(ProjekcijaModel projekcija)
        {
            InitializeComponent();
            BindingContext = model = new ProjekcijePrikazViewModel(projekcija);

            plakatImage.Source = ImageSource.FromStream(() => new MemoryStream(model.Projekcija.FilmPlakat));
            rezervacijaExists.IsVisible = model.RezervacijaExists;
            rezervacijaNotExists.IsVisible = !model.RezervacijaExists;

            dojamExists.IsVisible = model.DojamExists;
            dojamNotExists.IsVisible = !model.DojamExists;

            rezervacijaDatumProjekcije.MinimumDate = projekcija.VrijediOd;
            rezervacijaDatumProjekcije.MaximumDate = projekcija.VrijediDo;
        }
    }
}