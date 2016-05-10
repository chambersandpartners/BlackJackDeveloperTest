using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{

    public class CardManager
    {
        public static IList<Card> CreateDeck()
        {
            IList<Card> cards = new List<Card>();

            for (var cardType = 0; cardType < 4; cardType++)
            {
                for (var cardNumber = 0; cardNumber < 13; cardNumber++)
                {
                    cards.Add(new Card((CardType)cardType, (CardValue)cardNumber));
                }
            }

            return cards.ToList();
        }


        /// <summary>
        /// Todo: implement interface in order to allow other means of shuffling
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static Deck ShuffleDeck(IList<Card> cards)
        {            
            var rnd = new Random();
            return new Deck(cards.Select(o => o).OrderBy(o => rnd.Next()).ToList());
        }
    }
}
