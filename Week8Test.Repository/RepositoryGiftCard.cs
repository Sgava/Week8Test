using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Test.CORE.Entities;
using Week8Test.CORE.Interfaces;

namespace Week8Test.Repository
{
    public class RepositoryGiftCard : IRepositoryGiftCard
    {
        public static List<GiftCard> _ListaGift = new List<GiftCard>
        {
            new GiftCard
            {
                Id = 1,
                Destinatario = "Luca",
                Mittente = "Fabio",
                DataDiScadenza = new DateTime(2023,10,30),
                Importo = 300                
            },
            new GiftCard
            {
                Id = 2,
                Destinatario = "Sara",
                Mittente = "Gió",
                DataDiScadenza = new DateTime(2023,4,1),
                Importo = 200
            },
            new GiftCard
            {
                Id = 3,
                Destinatario = "CardProvaDaEliminare",
                Mittente = "Gió",
                DataDiScadenza = new DateTime(2023,4,1),
                Importo = 200
            }
        };
        public bool Add(GiftCard item)
        {
            if (item == null)
            {
                return false;
            }
            _ListaGift.Add(item);
            return true;
        }

        public GiftCard CercaGiftPerDestinatario(string nome)
        {
            var giftCard = _ListaGift.FirstOrDefault(g => g.Destinatario == nome);
            return giftCard;
        }

        public bool Delete(GiftCard item)
        {
            var giftCardDaEliminare = _ListaGift.FirstOrDefault(d => d.Destinatario == item.Destinatario);
            if (giftCardDaEliminare == null) return false;
            _ListaGift.Remove(giftCardDaEliminare);
            return true;
        }

        public List<GiftCard> GetAll()
        {
            return _ListaGift;
        }

        public bool Update(GiftCard item)
        {
            var giftCardDaAggiornare = _ListaGift.FirstOrDefault(d => d.Id == item.Id);
            giftCardDaAggiornare.Mittente = item.Mittente;
            giftCardDaAggiornare.Destinatario = item.Destinatario;
            giftCardDaAggiornare.Messaggio = item.Messaggio;    
            return true;
        }
    }
}
