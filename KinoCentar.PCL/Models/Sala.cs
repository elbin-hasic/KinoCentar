﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Shared.Models
{
    public class Sala
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public int? BrojSjedista { get; set; }
    }
}
