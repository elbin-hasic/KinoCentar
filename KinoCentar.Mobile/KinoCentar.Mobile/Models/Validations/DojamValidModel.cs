using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Mobile.Models.Validations
{
    public class DojamValidModel : BaseValidModel
    {
        bool ocjenaReqNotValid = false;
        public bool OcjenaReqNotValid
        {
            get { return ocjenaReqNotValid; }
            set { SetProperty(ref ocjenaReqNotValid, value); }
        }

        bool ocjenaErrNotValid = false;
        public bool OcjenaErrNotValid
        {
            get { return ocjenaErrNotValid; }
            set { SetProperty(ref ocjenaErrNotValid, value); }
        }
    }
}
