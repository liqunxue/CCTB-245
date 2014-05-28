using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    class DeckOfCards
    {
        // We are being pretty trusting letting them have direct access to our Cards
        // TODO: Change the data type to an IEnumerable<Card>......
        public List<Card> Cards { get; private set; }

        // the following is a good use of static members of a class
        private static Random _rnd = new Random(); // field for doing random studd

        public DeckOfCards()
        {
            // Add all 52 cards, in order
            Cards = new List<Card>();
            foreach (Suit aSuit in Enum.GetValues(typeof(Suit)))
                foreach (CardFace aFace in Enum.GetValues(typeof(CardFace)))
                    Cards.Add(new Card(aSuit, aFace));
        }

        public void Shuffle()
        {
            int counter = _rnd.Next(20, 50) * 52; // how many times to move a card
            while (counter > 0)
            {
                int index = _rnd.Next(Cards.Count);
                Card aCard = Cards[index];
                Cards.RemoveAt(index); // Pull it out from the middle
                Cards.Add(aCard); // Add it to the end
                counter--;
            }
        }
    }
}
