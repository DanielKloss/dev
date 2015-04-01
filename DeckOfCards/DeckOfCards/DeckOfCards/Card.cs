using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        readonly private Face _face;
        readonly private Suit _suit;

        readonly private int _sequentialValue;
        readonly public int numericValue;

        //readonly private string _graphicalSource;
        //readonly private string _unicodeGraphic;

        public Card(Face face, Suit suit, bool acesHigh)
        {
            _face = face;
            _suit = suit;

            _sequentialValue = (int)face;

            switch (face)
            {
                case Face.Ace:
                    if (acesHigh)
                        numericValue = 10;
                    else
                        numericValue = 1;
                    break;
                case Face.Jack:
                    numericValue = 10;
                    break;
                case Face.Queen:
                    numericValue = 10;
                    break;
                case Face.King:
                    numericValue = 10;
                    break;
                default:
                    numericValue = (int)face;
                    break;
            }

            //_graphicalSource = "Graphics/" + suit + "/" + face + ".png";

            //_unicodeGraphic = "U+1F0" + A + _sequentialValue;
        }
    }
}
