using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.API.EntityModels
{
    public class ProjekcijaRaspored
    {
        public ProjekcijaRaspored()
        {
            this.Vremena = new HashSet<ProjekcijaRasporedVrijeme>();
        }

        public int Id { get; set; }

        public int ProjekcijaId { get; set; }
        
        public DateTime Datum { get; set; }

        public virtual Projekcija Projekcija { get; set; }

        public virtual ICollection<ProjekcijaRasporedVrijeme> Vremena { get; set; }
    }
}
