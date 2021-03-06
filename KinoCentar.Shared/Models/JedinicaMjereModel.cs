﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Shared.Models
{
    public class JedinicaMjereModel
    {
        public int Id { get; set; }

        public string KratkiNaziv { get; set; }

        public string Naziv { get; set; }

        public string PuniNaziv 
        { 
            get
            {
                return $"{Naziv} [{KratkiNaziv}]";
            } 
        }
    }
}
