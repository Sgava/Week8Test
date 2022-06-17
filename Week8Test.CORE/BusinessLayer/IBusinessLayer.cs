using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Test.CORE.Entities;

namespace Week8Test.CORE.BusinessLayer
{
    public interface IBusinessLayer
    {
        bool CreaGiftCard(GiftCard gift);
        bool CancellaGiftCard(GiftCard gift);
        bool AggiornaGiftCard(GiftCard gift);
    }
}
