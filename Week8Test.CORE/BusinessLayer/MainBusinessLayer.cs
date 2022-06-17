using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Test.CORE.Entities;
using Week8Test.CORE.Interfaces;

namespace Week8Test.CORE.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryGiftCard _repositoryCard; 

        public MainBusinessLayer()
        {
            _repositoryCard = DependencyContainer.Resolve<IRepositoryGiftCard>();   
        }
        public bool AggiornaGiftCard(GiftCard gift)
        {
            throw new NotImplementedException();
        }

        public bool CancellaGiftCard(GiftCard gift)
        {
            _repositoryCard.Delete(gift);
            return true;
        }

        public bool CreaGiftCard(GiftCard gift)
        {
            throw new NotImplementedException();
        }

        public List<GiftCard> GetAllGiftCards()
        {
            return _repositoryCard.GetAll();
        }

        public GiftCard GetGiftCardByName(string nome)
        {
            return _repositoryCard.CercaGiftPerDestinatario(nome);
        }
    }
}
