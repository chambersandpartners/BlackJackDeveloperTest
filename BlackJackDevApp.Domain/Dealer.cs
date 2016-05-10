using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{
    public class Dealer : ICanPlay
    {
        public Dealer()
        {
            Hand = new List<Card>();
        }

        public Dealer(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public string Name { get; private set; }
        public IList<Card> Hand { get; private set; }

        public void AssignCard(Card card)
        {
            
            
        }
    }
}
