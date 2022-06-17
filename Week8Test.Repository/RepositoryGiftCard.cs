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
            }
        };
        public bool Add(GiftCard item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(GiftCard item)
        {
            throw new NotImplementedException();
        }

        public List<GiftCard> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(GiftCard item)
        {
            throw new NotImplementedException();
        }
    }
}
