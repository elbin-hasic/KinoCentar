using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Mobile.Models.Validations
{
    public class KorisnikValidModel : BaseValidModel
    {
        bool imeReqNotValid = false;
        public bool ImeReqNotValid
        {
            get { return imeReqNotValid; }
            set { SetProperty(ref imeReqNotValid, value); }
        }

        bool prezimeReqNotValid = false;
        public bool PrezimeReqNotValid
        {
            get { return prezimeReqNotValid; }
            set { SetProperty(ref prezimeReqNotValid, value); }
        }

        bool emailReqNotValid = false;
        public bool EmailReqNotValid
        {
            get { return emailReqNotValid; }
            set { SetProperty(ref emailReqNotValid, value); }
        }

        bool emailErrNotValid = false;
        public bool EmailErrNotValid
        {
            get { return emailErrNotValid; }
            set { SetProperty(ref emailErrNotValid, value); }
        }

        bool korisnickoImeReqNotValid = false;
        public bool KorisnickoImeReqNotValid
        {
            get { return korisnickoImeReqNotValid; }
            set { SetProperty(ref korisnickoImeReqNotValid, value); }
        }

        bool korisnickoImeErrNotValid = false;
        public bool KorisnickoImeErrNotValid
        {
            get { return korisnickoImeErrNotValid; }
            set { SetProperty(ref korisnickoImeErrNotValid, value); }
        }

        bool lozinkaReqNotValid = false;
        public bool LozinkaReqNotValid
        {
            get { return lozinkaReqNotValid; }
            set { SetProperty(ref lozinkaReqNotValid, value); }
        }

        bool lozinkaErrNotValid = false;
        public bool LozinkaErrNotValid
        {
            get { return lozinkaErrNotValid; }
            set { SetProperty(ref lozinkaErrNotValid, value); }
        }
    }
}
