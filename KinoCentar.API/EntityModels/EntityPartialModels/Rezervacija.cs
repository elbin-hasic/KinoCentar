using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.API.EntityModels
{
    public partial class Rezervacija
    {
        public virtual ProjekcijaRaspored ProjekcijaRaspored
        {
            get {
                return ProjekcijaRasporedVrijeme?.ProjekcijaRaspored;
            }
        }

        public virtual Projekcija Projekcija
        {
            get
            {
                return ProjekcijaRaspored?.Projekcija;
            }
        }
    }
}
