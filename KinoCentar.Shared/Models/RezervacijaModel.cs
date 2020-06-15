using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Shared.Models
{
    public class RezervacijaModel
    {
        public int Id { get; set; }

        public int ProjekcijaId { get; set; }

        public string FilmNaslov
        {
            get
            {
                return Projekcija?.Film?.Naslov;
            }
        }

        public string SalaNaziv
        {
            get
            {
                return Projekcija?.Sala?.Naziv;
            }
        }

        public int? KorisnikId { get; set; }

        public string KorisnikImePrezime
        {
            get
            {
                return Korisnik?.ImePrezime;
            }
        }

        public int BrojSjedista { get; set; }

        public decimal Cijena { get; set; }

        public DateTime Datum { get; set; }

        public DateTime DatumProjekcije { get; set; }

        public string DatumProjekcijeShortDate
        {
            get
            {
                return DatumProjekcije.ToShortDateString();
            }
        }

        public DateTime? DatumProdano { get; set; }        

        public bool IsProdano
        {
            get
            {
                return DatumProdano != null;
            }
        }

        public DateTime? DatumOtkazano { get; set; }

        public bool IsOtkazano
        {
            get
            {
                return DatumOtkazano != null;
            }
        }

        public ProjekcijaModel Projekcija { get; set; }

        public KorisnikModel Korisnik { get; set; }
    }
}
