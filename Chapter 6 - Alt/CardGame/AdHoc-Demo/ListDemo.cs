using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class ListDemo
    {
        public void Run()
        {
            // This is an example of the List<T> class AND of "generics"
            List<string> names; //declare a strongly-typed list of strings
            // names is a list that can only contain string objects
            names = new List<string>(); // instantiate the list - create an empty list

            FillWithData(names);
            Display(names);

            // Remove a name from the list
            names.Remove("Dan");
            Console.WriteLine("The name 'Dan' is removed...");
            Display(names);

        }

        // Private methods
        private void Display(List<string> data)
        {
            Console.WriteLine("There are " + data.Count + " items in the list of names");
            foreach (string item in data)
                Console.WriteLine("\t" + item);
            Console.WriteLine();// blank line
        }

        private void FillWithData(List<string> theData)
        {
            theData.Add("Guido");
            theData.Add("Dan");
            theData.Add("Sally");
            for (int count = 0; count < 3; count++)
            {
                Console.Write("Enter a name: ");
                theData.Add(Console.ReadLine());
            }
        }


    }
}
