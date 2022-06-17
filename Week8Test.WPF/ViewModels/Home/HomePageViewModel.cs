﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Test.CORE;
using Week8Test.CORE.BusinessLayer;
using Week8Test.CORE.Entities;

namespace Week8Test.WPF.ViewModels.Home
{
    public class HomePageViewModel
    {
        private IBusinessLayer Bl;        
        private List<string> _cardDaVisualizzareInHome = new List<string>();
        private List<string> _cardDaVisualizzareConDettagli = new List<string>();





        private List<string> CardDaVisualizzareInHome
        {
            get
            {
                return _cardDaVisualizzareInHome;
            }
            set
            {
                _cardDaVisualizzareInHome = value;
            }
        }
        private List<string> CardDaVisualizzareConDettagli
        {
            get
            {
                return _cardDaVisualizzareConDettagli;
            }
            set
            {
                _cardDaVisualizzareConDettagli= value;  
            }

        }



        public HomePageViewModel()
        {
            Bl = DependencyContainer.Resolve<IBusinessLayer>();
        }
    }
}
