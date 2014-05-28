// using statements allow me access to the classes in the stated namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.AdHoc_Demo; // To have access to my various collection-class demos
using CardGame.GameElements;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // comment or un-comment the following line to see/hide the demos
            // RunDemos();

            Program myApp = new Program();
            myApp.RunCardDemo();

        }
        public void DisplayPlayerCards(Player person)
        {
            Console.WriteLine("Looking at a players cards....");
            for (int index = 0; index < person.Count; index++)
                Console.WriteLine(person.Peek(index));
            Console.WriteLine();

        }
        public void RunCardDemo()
        {
            DeckOfCards myDeck = new DeckOfCards();
            myDeck.Shuffle();
            DisplayCards(myDeck);
            Player me = new Player(), you = new Player(), friend = new Player();
            myDeck.Deal(5, me, you, friend);
            //myDeck.Deal(7);
            //myDeck.Deal(4, null);
            DisplayPlayerCards(me);
            DisplayPlayerCards(you);

            // Uh-oh - not so secure .....
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            myDeck.Cards.Add(new Card(Suit.SPADES, CardFace.Ace));
            Console.WriteLine("There are {0} cards in the deck", myDeck.Cards.Count);

            // this won't compile...
            // myDeck.Cards = new List<Card>();

        }

        private static void DisplayCards(DeckOfCards myDeck)
        {
            // Just display all the cards
            foreach (Card item in myDeck.Cards)
                Console.WriteLine("{0} of {1}", item.Face, item.Suit);

        }


        static void RunDemos()
        {
            // Run some of the demos
            ArrayDemo demo1 = new ArrayDemo();
            demo1.Run();

            ListDemo demo2 = new ListDemo();
            demo2.Run();

            QueueDemo demo3 = new QueueDemo();
            demo3.Run();

            StackDemo demo4 = new StackDemo();
            demo4.Run();
        }
    }
}
