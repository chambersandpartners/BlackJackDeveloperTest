using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlackJackDevApp.Domain;
using BlackJackAPI.Models;

namespace BlackJackAPI.Controllers
{
    public class BlackJackController : ApiController
    {
        private Game _currentGame;

        public BlackJackController()
        {
            
        }

        public HttpMessageContent StartGame(CreateBlackJackGameModel newGame)
        {
            // TODO: Create player, create dealer, create shuffled deck

            ICanPlay player = new Player(newGame.PlayerName);
            ICanPlay dealer = new Player(newGame.DealerName);

            var unshuffledDeck = CardManager.CreateDeck();
            var shuffledDeck = CardManager.ShuffleDeck(unshuffledDeck);

            _currentGame = Game.CreateGame(player, dealer, shuffledDeck);

            return null;
        }

        public HttpMessageContent Hit()
        {
            // 
            _currentGame.DealToPlayer();

            


            return null;
        }

        public HttpMessageContent Stick()
        {
            // When the player sticks, the dealer will hit until 17 or greater




            return null;
        }

    }
}
