using System.Linq;
using BlackJack.Dtos;
using NUnit.Framework;

namespace BlackJack.Service.Tests
{
    public class DealerServiceTest
    {
        [Test]
        public void WhenIPickUpTheDeck_ThenIAmReturnedAllCards()
        {
            var service = new DealerService();

            var cards = service.PickUpCards().ToList();

            Assert.That(cards.Count, Is.EqualTo(52));
        }

        [Test]
        public void WhenIPickUpTheDeck_ThenTheCardsArentShuffled()
        {
            var service = new DealerService();

            var cards = service.PickUpCards().ToList();

            Assert.That(cards.First().Name, Is.EqualTo("Ace"));
            Assert.That(cards.First().Suit, Is.EqualTo(Suit.Clubs));

            Assert.That(cards.Last().Name, Is.EqualTo("King"));
            Assert.That(cards.Last().Suit, Is.EqualTo(Suit.Spades));
        }

        [Test]
        public void WhenIShuffleTheCards_ThenTheyAreInARandomOrder()
        {
            var service = new DealerService();

            var originalCards = service.PickUpCards().ToList();

            var shuffledCards = service.ShuffleCards().ToList();

            var matchingCards = 0;

            for (var i = 0; i < originalCards.Count; i++)
            {
                if (originalCards[i].Name == shuffledCards[i].Name && originalCards[i].Value == shuffledCards[i].Value)
                {
                    matchingCards ++;
                }
            }

            Assert.That(matchingCards != originalCards.Count);
        }
    }
}
