using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class ArrayDemo
    {
        public void Run()
        {
            // Declare an array reference variable
            int[] myInfo;
            // Create the actual array of 5 integers
            myInfo = new int[5]; // here, the number represents the SIZE of the new array

            FillWithRandom(myInfo);
            Display(myInfo);

            // How could I sort an array of integers?
            Array.Sort(myInfo); // faster way of sorting that one that I could code
            Display(myInfo);

            // change the data
            FillWithRandom(myInfo);
            Display(myInfo);
            // TODO: Demo Sorting Arrays with .OrderBy() Extension method
        }

        

        // Private methods

        private void FillWithRandom(int[] theArray)
        {
            Random rnd = new Random(); // this object is a random-number generator
            for (int index = 0; index < theArray.Length; index++)
            {
                theArray[index] = rnd.Next(1, 100);
            }
        }

        private void Display(int[] data)
        {
            // TODO: Code to show the size of the array, and each value in the array
            Console.WriteLine("The array has " + data.Length + " elements:");
            foreach (int item in data) // forward-only for loop through all elements
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine(); // blank line
        }
    }
}
