using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckOfCards.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardShouldBeGivenCorrectNumericValue()
        {
            Card King = new Card(Face.King, Suit.Clubs, true);
            Card Queen = new Card(Face.Queen, Suit.Clubs, true);
            Card Jack = new Card(Face.Jack, Suit.Clubs, true);
            Card Ten = new Card(Face.Ten, Suit.Clubs, true);
            Card Nine = new Card(Face.Nine, Suit.Clubs, true);
            Card Eight = new Card(Face.Eight, Suit.Clubs, true);
            Card Seven = new Card(Face.Seven, Suit.Clubs, true);
            Card Six = new Card(Face.Six, Suit.Clubs, true);
            Card Five = new Card(Face.Five, Suit.Clubs, true);
            Card Four = new Card(Face.Four, Suit.Clubs, true);
            Card Three = new Card(Face.Three, Suit.Clubs, true);
            Card Two = new Card(Face.Two, Suit.Clubs, true);

            Assert.AreEqual(King.numericValue, 10);
            Assert.AreEqual(Queen.numericValue, 10);
            Assert.AreEqual(Jack.numericValue, 10);
            Assert.AreEqual(Ten.numericValue, 10);
            Assert.AreEqual(Nine.numericValue, 9);
            Assert.AreEqual(Eight.numericValue, 8);
            Assert.AreEqual(Seven.numericValue, 7);
            Assert.AreEqual(Six.numericValue, 6);
            Assert.AreEqual(Five.numericValue, 5);
            Assert.AreEqual(Four.numericValue, 4);
            Assert.AreEqual(Three.numericValue, 3);
            Assert.AreEqual(Two.numericValue, 2);
        }

        [TestMethod]
        public void AcesShouldBeGivenValueOfOneIfAcesNotHigh()
        {
            Card Ace = new Card(Face.Ace, Suit.Clubs, false);

            Assert.AreEqual(Ace.numericValue, 1);
        }

        [TestMethod]
        public void AcesShouldBeGivenValueOfTenIfAcesHigh()
        {
            Card Ace = new Card(Face.Ace, Suit.Clubs, true);

            Assert.AreEqual(Ace.numericValue, 10);
        }
    }
}
