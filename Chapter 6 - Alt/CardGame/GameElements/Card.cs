using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    // Extra data types that relate to the Card class
    enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }
    enum CardFace
    {
        Ace = 1,
        Deuce,
        Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
    }

    // An Immutable type - It cannot be changed
    class Card
    {
        public Suit Suit { get; private set; }
        public CardFace Face { get; private set; }

        public int FaceValue
        {
            get
            {
                int value = (int)FaceValue; // one valid use of casting ....
                if (value > 10)
                    value = 10; // Jack, Queen, and King
                return value;
            }
        }
        // TODO: Create a constructor that takes two parameters: a Suit and a CardFace
        public Card(Suit theSuit, CardFace theFace)
        {
            this.Suit = theSuit;
            this.Face = theFace;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }




}
