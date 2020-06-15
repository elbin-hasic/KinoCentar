using KinoCentar.Shared.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoCentar.WinUI
{
    public static class Global
    {
        public static KorisnikModel PrijavljeniKorisnik { get; set; }

        #region API Routes

        public static string ApiAddress
        {
            get
            {
                return ConfigurationSettings.API_ADDRESS;
            }
        }

        public static string KorisniciRoute = "api/Korisnici";
        public static string TipoviKorisnikaRoute = "api/TipoviKorisnika";
        public static string SaleRoute = "api/Sale";
        public static string ZanroviRoute = "api/Zanrovi";
        public static string JediniceMjereRoute = "api/JediniceMjere";

        public static string FilmoviRoute = "api/Filmovi";
        public static string FilmskeLicnostiRoute = "api/FilmskeLicnosti";
        public static string ProjekcijeRoute = "api/Projekcije";
        public static string ArtikliRoute = "api/Artikli";
        public static string RezervacijeRoute = "api/Rezervacije";
        public static string ProdajaRoute = "api/Prodaja";

        public static string ObavijestiRoute = "api/Obavijesti";
        public static string DojmoviRoute = "api/Dojmovi";

        #endregion
    }
}
