using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KinoCentar.Shared.Models
{
    public class ProjekcijaModel
    {
        public int Id { get; set; }

        public int FilmId { get; set; }

        public string FilmNaslov 
        {
            get
            {
                return Film?.Naslov;
            }
        }

        public string FilmSadrzaj
        {
            get
            {
                return Film?.Sadrzaj;
            }
        }

        public byte[] FilmPlakatThumb
        {
            get
            {
                return Film?.PlakatThumb;
            }
        }

        public byte[] FilmPlakat
        {
            get
            {
                return Film?.Plakat;
            }
        }

        public int SalaId { get; set; }

        public string SalaNaziv
        {
            get
            {
                return Sala?.Naziv;
            }
        }

        public decimal Cijena { get; set; }

        public DateTime Datum { get; set; }

        public DateTime VrijediOd { get; set; }

        public string VrijediOdShortDate
        {
            get
            {
                return VrijediOd.ToShortDateString();
            }
        }

        public DateTime VrijediDo { get; set; }

        public string VrijediDoShortDate
        {
            get
            {
                return VrijediDo.ToShortDateString();
            }
        }

        public string VrijediOdDoShortDate
        {
            get
            {
                return $"{VrijediOd.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)} - {VrijediDo.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}";
            }
        }

        public FilmModel Film { get; set; }

        public SalaModel Sala { get; set; }
    }
}
