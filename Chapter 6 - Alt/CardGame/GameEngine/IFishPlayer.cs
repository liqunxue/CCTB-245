using CardGame.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* An interface defines the signature ( not the implementation) for
 * a set of properties and/or methods
 */

namespace CardGame.GameEngine
{
    // The IFishPlayer is used in the game "Go Fish!"
    public interface IFishPlayer
    {
        void ShowCards(); // notice the semicolon, even though this has a parameter list
        bool Ask(IFishPlayer person); // the semicolon is here instead of the method body
        Card Reply(Card askedFor);
        // NOTE: IT's probably better to put a Stack<Card> as the PlayerPile here...
        Stack<Card> PlayerPile { get; set; }

    }
}
