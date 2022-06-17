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
                Destinatario = "Luca",
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
