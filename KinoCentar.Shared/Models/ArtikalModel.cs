using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Shared.Models
{
    public class ArtikalModel
    {
        public int Id { get; set; }

        public int JedinicaMjereId { get; set; }

        public string Sifra { get; set; }

        public string Naziv { get; set; }

        public decimal Cijena { get; set; }

        public byte[] Slika { get; set; }

        public JedinicaMjereModel JedinicaMjere { get; set; }
    }
}
