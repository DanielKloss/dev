using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {
        private Random r = new Random();

        private IList<Card> _cardsInDeck;
        public IList<Card> cardsInDeck
        {
            get { return _cardsInDeck; }
            set { _cardsInDeck = value; }
        }

        public Deck(bool acesHigh)
        {
            cardsInDeck = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    cardsInDeck.Add(new Card(face, suit, acesHigh));
                }
            }
        }

        public void AddToTopOfDeck(Card cardToAdd)
        {
            cardsInDeck.Insert(0, cardToAdd);
        }

        public Card RemoveFromTopOfDeck()
        {
            Card cardToRemove = cardsInDeck[0];
            cardsInDeck.RemoveAt(0);

            return cardToRemove;
        }

        public void Shuffle()
        {
            for (int n = cardsInDeck.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = cardsInDeck[n];
                cardsInDeck[n] = cardsInDeck[k];
                cardsInDeck[k] = temp;
            }
        }

        public void AddToIndex(int index, Card cardToAdd)
        {
            cardsInDeck.Insert(index, cardToAdd);
        }

        public Card RemoveFromIndex(int index)
        {
            Card cardToRemove = cardsInDeck[index];
            cardsInDeck.RemoveAt(index);

            return cardToRemove;
        }

        public Card RemoveAtRandom()
        {
            int randomIndex = r.Next(0, 52);
            Card cardToRemove = cardsInDeck[randomIndex];
            cardsInDeck.RemoveAt(randomIndex);

            return cardToRemove;
        }
    }
}
