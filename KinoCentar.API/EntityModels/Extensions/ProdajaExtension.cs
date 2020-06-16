using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoCentar.API.EntityModels.Extensions
{
    public class ProdajaExtension : Prodaja
    {
        public decimal UkupnaCijena { get; set; }

        public ProdajaExtension(Prodaja prodaja)
        {
            Id = prodaja.Id;
            BrojRacuna = prodaja.BrojRacuna;
            KorisnikId = prodaja.KorisnikId;
            Datum = prodaja.Datum;
            Popust = prodaja.Popust;
            Porez = prodaja.Porez;
            Korisnik = prodaja.Korisnik;
            UkupnaCijena = GetUkupnaCijena(prodaja.ArtikliStavke, prodaja.RezervacijeStavke);
        }

        private decimal GetUkupnaCijena(ICollection<ProdajaArtikalDodjela> artikliStavke, ICollection<ProdajaRezervacijaDodjela> rezervacijeStavke)
        {
            decimal ukupnaCijena = 0;

            foreach (var artikalStavka in artikliStavke)
            {
                ukupnaCijena += (artikalStavka.Cijena * artikalStavka.Kolicina);
            }

            foreach (var rezStavka in rezervacijeStavke)
            {
                ukupnaCijena += rezStavka.Cijena;
            }

            return ukupnaCijena;
        }
    }
}
