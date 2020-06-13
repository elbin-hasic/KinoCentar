using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KinoCentar.API.EntityModels
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            this.Prodaja = new HashSet<ProdajaRezervacijaDodjela>();
        }

        public int Id { get; set; }

        public int ProjekcijaRasporedVrijemeId { get; set; }

        public int KorisnikId { get; set; }

        public decimal Cijena { get; set; }

        public DateTime Datum { get; set; }

        public virtual ProjekcijaRasporedVrijeme ProjekcijaRasporedVrijeme { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual ICollection<ProdajaRezervacijaDodjela> Prodaja { get; set; }
    }
}
