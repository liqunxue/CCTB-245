using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    public class Player
    {
        protected List<Card> Hand { get; set; }
        public int Count { get { return Hand.Count; } }

        public Player()
        {
            Hand = new List<Card>(); // empty list
        }

        public void Add(Card freshCard)
        {
            Hand.Add(freshCard);
        }

        public Card Peek(int cardPosition)
        {
            if (cardPosition < 0 || cardPosition >= Count)
                throw new ArgumentOutOfRangeException("No card at position " + cardPosition + " - only " + Count + " cards in my hand.");
            return Hand[cardPosition];
        }

        public Card Pull(int cardPosition)
        {
            if (cardPosition < 0 || cardPosition >= Count)
                throw new ArgumentOutOfRangeException("No card at position " + cardPosition + " - only " + Count + " cards in my hand.");
            Card discarded = Hand[cardPosition];
            Hand.RemoveAt(cardPosition);
            return discarded;
        }
    }
}
