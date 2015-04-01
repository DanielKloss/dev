using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckOfCards.Tests
{
    [TestClass]
    public class DeckTests
    {
        Deck deck;
        Random r = new Random();

        [TestInitialize]
        public void TestSetup()
        {
            deck = new Deck(true);
        }

        [TestMethod]
        public void DeckShouldConstructWith52Cards()
        {
            int expectedCount = 52;

            Assert.AreEqual(expectedCount, deck.cardsInDeck.Count);
        }

        [TestMethod]
        public void DeckShouldNotBeInTheSameOrderAfterShuffling()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CardShouldBeAddedToTopOfDeck()
        {
            Card cardToAdd = new Card(Face.King, Suit.Clubs, true);

            deck.AddToTopOfDeck(cardToAdd);

            Assert.AreEqual(deck.cardsInDeck.First<Card>(), cardToAdd);
        }

        [TestMethod]
        public void CardShouldBeRemovedFromTopOfDeck()
        {
            Card expectedCard = deck.cardsInDeck[0];

            Card removedCard = deck.RemoveFromTopOfDeck();

            Assert.AreEqual(expectedCard, removedCard);
            Assert.AreNotEqual(expectedCard, deck.cardsInDeck.First<Card>());
        }

        [TestMethod]
        public void CardShouldBeAddedToGivenIndex()
        {
            int indexToAddTo = 2;
            Card cardToAdd = new Card(Face.King, Suit.Clubs, true);

            deck.AddToIndex(indexToAddTo, cardToAdd);

            Assert.AreEqual(deck.cardsInDeck[indexToAddTo], cardToAdd);
        }

        [TestMethod]
        public void CardShouldBeRemovedFromGivenIndex()
        {
            int indexToRemoveFrom = 2;
            Card expectedCard = deck.cardsInDeck[indexToRemoveFrom];

            Card removedCard = deck.RemoveFromIndex(indexToRemoveFrom);

            Assert.AreEqual(expectedCard, removedCard);
            Assert.AreNotEqual(expectedCard, deck.cardsInDeck[indexToRemoveFrom]);
        }

        [TestMethod]
        public void CardShouldBeRemovedFromRandomIndex()
        {
            int indexToRemoveFrom = r.Next(0,52);
            Card expectedCard = deck.cardsInDeck[indexToRemoveFrom];

            Card removedCard = deck.RemoveFromIndex(indexToRemoveFrom);

            Assert.AreEqual(expectedCard, removedCard);
            Assert.AreNotEqual(expectedCard, deck.cardsInDeck[indexToRemoveFrom]);
        }
    }
}
