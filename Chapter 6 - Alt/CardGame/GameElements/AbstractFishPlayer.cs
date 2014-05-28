using CardGame.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    // This class inherits from the Player class,
    // and implements part of the IFishPlyaer interface.
    // This is also an abstract class, meaning that
    // I cannot create an instance of this class;
    // I can only create instance of sub-classes.
    public abstract class AbstractFishPlayer : Player, IFishPlayer
    {
        public Stack<Card> PlayerPile { get; set; }
        public AbstractFishPlayer()
        {
            PlayerPile = new Stack<Card>(); // empty stack of cards
        }
    }

    // TODO: Move this class to a separate file ...
    // This class needs to finish the rest of the implementation
    // for the IFishPlayer. ( The PlayerPile property is implemented
    //
    public class ComputerPlayer : AbstractFishPlayer, IFishPlayer
    {
        public void ShowCards()
        {
            Console.WriteLine("Looking at my cards....");
            foreach (var card in Hand)
                Console.WriteLine(card);
            Console.WriteLine();
        }
        public bool Ask(IFishPlayer person)
        {
            // TODO: move rnd to base class as a field....
            Random rnd = new Random();
            Card askedFor = Hand[rnd.Next(Count)]; // pick some random card
            Console.WriteLine("\tDo you have a " + askedFor + "?");
            Card result = person.Reply(askedFor);
            if (result != null)
                return true;
            else
                return false;
        }

        public Card Reply(Card askedFor)
        {
            Card myreply = null;
            foreach (var card in Hand)
                ;
            return myreply;
        }

    }
}
