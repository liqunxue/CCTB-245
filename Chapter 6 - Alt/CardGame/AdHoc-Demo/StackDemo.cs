using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class StackDemo
    {
        public void Run()
        {
            Stack<string> items = new Stack<string>();
            FillWithData(items);
            EmptyAndDisplay(items);
        }


        // private methods

        private void FillWithData(Stack<string> items)
        {
            items.Push("First"); // Use the .Enqueue() method to add to the end
            items.Push("Second");
            items.Push("Third");
            items.Push("Fourth");
        }


        private void EmptyAndDisplay(Stack<string> data)
        {
            Console.WriteLine("There are " + data.Count + " items in the queue:");
            foreach (string text in data)
                Console.Write(text + ",");
            Console.WriteLine();
            Console.WriteLine("... now emptying data...");
            while (data.Count > 0)
                Console.WriteLine(data.Pop());
            Console.WriteLine();
        }
    }
}
