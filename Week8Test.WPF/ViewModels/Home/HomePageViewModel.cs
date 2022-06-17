using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Week8Test.CORE;
using Week8Test.CORE.BusinessLayer;
using Week8Test.CORE.Entities;
using Week8Test.WPF.Messages;

namespace Week8Test.WPF.ViewModels.Home
{
    public class HomePageViewModel : ViewModelBase
    {
        private IBusinessLayer Bl;
        private List<string> _cardDaVisualizzareInHome = new List<string>();
        private string _cardDaVisualizzareConDettagli;
        private string _cardSelezionata;
        private bool _isChecked = false;
        public ICommand MostraCardCommand { get; set; }
        public ICommand EliminaGiftCardCommand { get; set; }
        public ICommand VaiAllaVistaCreaCommand { get; set; }  

        
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                RaisePropertyChanged();
            }
        }

        public List<string> CardDaVisualizzareInHome
        {
            get
            {
                return _cardDaVisualizzareInHome;
            }
            set
            {
                _cardDaVisualizzareInHome = value;
                RaisePropertyChanged();
            }
        }

        public string CardDaVisualizzareConDettagli
        {
            get
            {
                return _cardDaVisualizzareConDettagli;
            }
            set
            {
                _cardDaVisualizzareConDettagli = value;
                RaisePropertyChanged();
            }

        }

        public string CardSelezionata
        {
            get
            {
                return _cardSelezionata;
            }
            set
            {
                _cardSelezionata = value;
                RaisePropertyChanged();
            }
        }
           



        public HomePageViewModel()
        {
            MostraCardCommand = new RelayCommand(MostraDettagliCard);
            EliminaGiftCardCommand = new RelayCommand(EliminaGiftCard);
            VaiAllaVistaCreaCommand = new RelayCommand(VaiAllaVistaCrea);
            Bl = DependencyContainer.Resolve<IBusinessLayer>();
            var lista = Bl.GetAllGiftCards();
            foreach (var card in lista)
            {
                CardDaVisualizzareInHome.Add($"{card.Destinatario} - {card.Importo}€");
            }
        }

        private void VaiAllaVistaCrea()
        {
            var showCreateMessage = new ShowViewMessage { ViewName = "InserGiftCardView" };
            Messenger.Default.Send(showCreateMessage);
        }

        private void EliminaGiftCard()
        {          
            var objDaEliminare = Bl.GetGiftCardByName(RicavaNome(CardSelezionata));
            Bl.CancellaGiftCard(objDaEliminare);
        }

        private void MostraDettagliCard()
        {

            var objDaMostrare = Bl.GetGiftCardByName(RicavaNome(CardSelezionata));
            CardDaVisualizzareConDettagli = objDaMostrare.ToLongString();
        }

        private string RicavaNome(string stringaSelezionata)
        {
            var nomeDestinatario = Regex.Replace(stringaSelezionata.Split()[0], @"[^0-9a-zA-Z\ ]+", "");            
            return nomeDestinatario;
        }
    }
}
