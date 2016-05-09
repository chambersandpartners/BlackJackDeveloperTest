using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using BlackJack.Dtos;

namespace BlackJack.Service
{
    public class DealerService
    {
        public DealerService()
        {
            DealersHand = new List<Card>();
        }

        private IList<Card> DealersHand { get; set; }

        public IEnumerable<Card> PickUpCards()
        {
            SetAllCards();
            return DealersHand;
        }

        public IEnumerable<Card> ShuffleCards()
        {
            var random = new Random();
            var indexOfCards = new List<int>();
            var shuffledCards = new List<Card>();
            var i = 0;
            while (i < 51)
            {
                var index = random.Next(0, 51);
                if (indexOfCards.Contains(index))
                    continue;

                indexOfCards.Add(i);
                shuffledCards.Add(DealersHand[index]);
                i ++;
            }

            DealersHand = shuffledCards;

            return DealersHand;
        } 

        private void SetAllCards()
        {
            var suits = new List<Suit> {Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades};

            var cards = new List<Card>()
            {
                new Card {Name = "Ace", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {1, 11}}},
                new Card {Name = "Two", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {2}}},
                new Card {Name = "Three", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {3}}},
                new Card {Name = "Four", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {4}}},
                new Card {Name = "Five", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {5}}},
                new Card {Name = "Six", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {6}}},
                new Card {Name = "Seven", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {7}}},
                new Card {Name = "Eight", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {8}}},
                new Card {Name = "Nine", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {9}}},
                new Card {Name = "Ten", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {10}}},
                new Card {Name = "Jack", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {10}}},
                new Card {Name = "Queen", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {10}}},
                new Card {Name = "King", Suit = Suit.Clubs, Value = new CardValue {ValueOptions = new List<int> {10}}},
            };

            suits.ForEach(s => cards.ForEach(c => DealersHand.Add(new Card {Name = c.Name, Suit = s, Value = c.Value})));
        }
    }
}
