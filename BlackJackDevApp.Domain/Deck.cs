using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{
    public class Deck
    {
        private Stack<Card> _cards;
        
        public Deck(List<Card> cards)
        {
            if (cards == null)
                throw new Exception("Cards are null");
            if (cards.Count != 52)
                throw new Exception("There are not the right amount of cards");

            _cards = new Stack<Card>();

            foreach (var card in cards)
            {
                _cards.Push(card);
            }
        }

        public Card DealCard()
        {
            var card = _cards.Pop();

            return card;
        }
    }
}
