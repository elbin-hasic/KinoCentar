﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Shared.Models
{
    public class ProdajaArtikalDodjelaModel
    {
        public int Id { get; set; }

        public int ProdajaId { get; set; }

        public int ArtikalId { get; set; }

        public decimal Cijena { get; set; }

        public int Kolicina { get; set; }

        public ProdajaModel Prodaja { get; set; }

        public ArtikalModel Artikal { get; set; }
    }
}
