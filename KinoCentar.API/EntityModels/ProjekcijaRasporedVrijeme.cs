using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.API.EntityModels
{
    public class ProjekcijaRasporedVrijeme
    {
        public ProjekcijaRasporedVrijeme()
        {
            this.Rezervacije = new HashSet<Rezervacija>();
        }

        public int Id { get; set; }
        
        public int ProjekcijaRasporedId { get; set; }
        
        public TimeSpan Vrijeme { get; set; }

        public virtual ProjekcijaRaspored ProjekcijaRaspored { get; set; }

        public virtual ICollection<Rezervacija> Rezervacije { get; set; }
    }
}
