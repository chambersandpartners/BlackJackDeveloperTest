using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{
    public class Player : ICanPlay
    {
        public Player()
        {
            Hand = new List<Card>();
        }
        public Player(string name)
        {
            // Name and hand validation
            Hand = new List<Card>();
            Name = name;
        }
        public string Name { get; private set; }
        public IList<Card> Hand { get; private set; }

        public void AssignCard(Card card)
        {
            Hand.Add(card);

        }

        public 
    }
}
