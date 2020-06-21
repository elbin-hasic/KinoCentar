using System;
using System.Collections.Generic;
using System.Text;

namespace KinoCentar.Mobile.ViewModels
{
    public class BaseListViewModel : BaseViewModel
    {
        bool isEmptyList = false;
        public bool IsEmptyList
        {
            get { return isEmptyList; }
            set { SetProperty(ref isEmptyList, value); }
        }
    }
}
