using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.PCL.Models
{
    public class Korisnik
    {
        public int Id { get; set; }

        public int TipKorisnikaId { get; set; }

        public string KorisnickoIme { get; set; }

        public string LozinkaHash { get; set; }

        public string LozinkaSalt { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Email { get; set; }

        public string Spol { get; set; }

        public DateTime? DatumRodjenja { get; set; }

        public byte[] Slika { get; set; }
    }
}
