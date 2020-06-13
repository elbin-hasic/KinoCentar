using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KinoCentar.API.EntityModels
{
    public class FilmZanrDodjela
    {
        public int Id { get; set; }

        public int FilmId { get; set; }

        public int ZanrId { get; set; }

        public virtual Film Film { get; set; }

        public virtual Zanr Zanr { get; set; }
    }
}
