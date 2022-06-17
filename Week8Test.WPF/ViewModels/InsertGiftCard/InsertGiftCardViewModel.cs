using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Test.CORE;
using Week8Test.CORE.BusinessLayer;

namespace Week8Test.WPF.ViewModels.InsertGiftCard
{
    public class InsertGiftCardViewModel : ViewModelBase
    {
        private IBusinessLayer Bl;


        public InsertGiftCardViewModel()
        {
            Bl = DependencyContainer.Resolve<IBusinessLayer>();
        }
    }
}
