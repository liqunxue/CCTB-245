using CardGame.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameEngine
{
    class GoFish
    {
        private DeckOfCards Deck { get; set; }
        private Player[] Players { get; set; }

        public GoFish(params AbstractFishPlayer[] players)
        {
            // TODO: Validate the list of players, that there are from 2 to 5 players
            this.Players = Players;
            Deck = new DeckOfCards();
        }

        public void Play()
        {
            // Run the game - this is like the Main() method of your game
            SetUp();
            bool gameOver = false;
            Player winner = null;
            do
            {
                foreach (var person in Players)
                {
                    // as IFishPlayer is an exmple of "safe casting"
                    bool foundMatch = TakeTurn(person as IFishPlayer);
                    if (foundMatch)
                        RemovePairs(person);
                    if (person.Count == 0)
                    {
                        gameOver = true;
                        winner = person;
                        break; //jump out of this foreach loop
                    }
                }
            } while (!gameOver);
            // TODO: Find some way to say who won.....
        }



        private void SetUp()
        {
            Deck.Shuffle();
            Deck.Deal(5, Players);

        }

    }
}
