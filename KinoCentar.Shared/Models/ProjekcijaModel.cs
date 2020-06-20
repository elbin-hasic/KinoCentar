using System;
using System.Collections.Generic;
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

        public byte[] FilmPlakatThumb
        {
            get
            {
                return Film?.PlakatThumb;
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

        public FilmModel Film { get; set; }

        public SalaModel Sala { get; set; }
    }
}
