using Week8Test.CORE;
using Week8Test.CORE.BusinessLayer;
using Week8Test.CORE.Entities;
using Xunit;

namespace Week8Test.Test
{
    public class TestFunzionalitaHome
    {
        [Fact]
        public void TestVisualizzazioneDettagli()
        {
            IBusinessLayer Bl;
            Bl = DependencyContainer.Resolve<IBusinessLayer>();
            var giftcardProva = new GiftCard()
            {
                Id = 1,
                Destinatario = "Luca",
                Mittente = "Fabio",
                DataDiScadenza = new DateTime(2023, 10, 30),
                Importo = 300
            };

            List<GiftCard> listaTest = new List<GiftCard>();
            listaTest.Add(giftcardProva);

            Assert.Equal(giftcardProva.ToLongString(), Bl.GetGiftCardByName(giftcardProva.Destinatario).ToLongString());
            
            
        }
    }
}