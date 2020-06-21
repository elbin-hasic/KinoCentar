using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KinoCentar.API.EntityModels
{
    public class Projekcija
    {
        public Projekcija()
        {
            this.Rezervacije = new HashSet<Rezervacija>();
            this.PosjeteKorisnika = new HashSet<ProjekcijaKorisnikDodjela>();
        }

        public int Id { get; set; }

        public int FilmId { get; set; }

        public int SalaId { get; set; }

        public decimal Cijena { get; set; }

        public DateTime Datum { get; set; }

        public DateTime VrijediOd { get; set; }

        public DateTime VrijediDo { get; set; }

        public virtual Film Film { get; set; }

        public virtual Sala Sala { get; set; }

        public virtual ICollection<Rezervacija> Rezervacije { get; set; }

        public virtual ICollection<ProjekcijaKorisnikDodjela> PosjeteKorisnika { get; set; }
    }
}
