using KinoCentar.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KinoCentar.Mobile
{
    public class Global
    {
        public static KorisnikModel PrijavljeniKorisnik { get; set; }

        #region API Routes

        public static string ApiAddress
        {
            get
            {
                return Application.Current.Resources["ApiAddress"].ToString();
            }
        }

        public static string KorisniciRoute = "api/Korisnici";
        public static string ProjekcijeRoute = "api/Projekcije";
        public static string RezervacijeRoute = "api/Rezervacije";

        public static string ObavijestiRoute = "api/Obavijesti";
        public static string DojmoviRoute = "api/Dojmovi";

        #endregion
    }
}
