using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{
    public class Game
    {
        public ICanPlay Player { get; private set; }
        public ICanPlay Dealer { get; private set; }

        private Deck _deck;

        public Game(ICanPlay player, ICanPlay dealer, Deck deck)
        {
            Player = player;
            Dealer = dealer;
            _deck = deck;
        }

        public static Game CreateGame(ICanPlay player, ICanPlay dealer, Deck deck)
        {            
            return new Game(player, dealer, deck);
        }

        public void DealToPlayer()
        {
            var card = _deck.DealCard();

            Player.AssignCard(card);
        }

        public void DealToDealer()
        {
            var card = _deck.DealCard();

            Dealer.AssignCard(card);
        }
    }
}
