﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Mobile.Models
{
    public enum MenuItemType
    {
        Pocetna,
        Projekcije,
        Preporuceno,
        Rezervacije,
        Obavijesti,
        //
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
