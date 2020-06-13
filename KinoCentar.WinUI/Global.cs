using KinoCentar.PCL.Models;
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
        public static Korisnik prijavljeniKorisnik { get; set; }

        #region API Routes

        public static string API_ADDRESS
        {
            get
            {
                return ConfigurationManager.AppSettings["APIAddress"];
            }
        }

        public static string KorisniciRoute = "api/Korisnici";
        public static string TipoviKorisnikaRoute = "api/TipoviKorisnika";
        public static string SaleRoute = "api/Sale";
        public static string ZanroviRoute = "api/Zanrovi";
        public static string JediniceMjereRoute = "api/JediniceMjere";

        public static string FilmoviRoute = "api/Filmovi";
        public static string ProjekcijeRoute = "api/Projekcije";
        public static string RezervacijeRoute = "api/Rezervacije";
        public static string ArtikliRoute = "api/Artikli";
        public static string FilmskeLicnostiRoute = "api/FilmskeLicnosti";

        #endregion
    }
}
