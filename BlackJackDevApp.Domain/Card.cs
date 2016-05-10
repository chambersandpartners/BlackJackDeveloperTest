using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDevApp.Domain
{
    public enum CardType
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    };
   

    public class Card
    {
        public CardType Type { get; }
        public CardValue Value { get; }

        public Card(CardType type, CardValue value)
        {
            Type = type;
            Value = value;
        }

        public int GetValue()
        {
            if (Value == CardValue.Ace || Value == CardValue.Jack || Value == CardValue.Queen || Value == CardValue.King)
                return 10;

            return Convert.ToInt32(Value);
        }
    }
}
