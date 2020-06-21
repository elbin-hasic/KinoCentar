using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Mobile.Models.Validations
{
    public class RezervacijaValidModel : BaseValidModel
    {
        bool brojSjedistaReqNotValid = false;
        public bool BrojSjedistaReqNotValid
        {
            get { return brojSjedistaReqNotValid; }
            set { SetProperty(ref brojSjedistaReqNotValid, value); }
        }

        bool brojSjedistaErrNotValid = false;
        public bool BrojSjedistaErrNotValid
        {
            get { return brojSjedistaErrNotValid; }
            set { SetProperty(ref brojSjedistaErrNotValid, value); }
        }

        bool datumProjekcijeErrNotValid = false;
        public bool DatumProjekcijeErrNotValid
        {
            get { return datumProjekcijeErrNotValid; }
            set { SetProperty(ref datumProjekcijeErrNotValid, value); }
        }
    }
}
