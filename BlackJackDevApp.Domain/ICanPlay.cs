using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{
    public interface ICanPlay
    {
        string Name { get; }
        IList<Card> Hand { get; }
        void AssignCard(Card card);
    }
}
