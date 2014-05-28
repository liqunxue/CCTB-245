using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class QueueDemo
    {
        public void Run()
        {
            Queue<string> items = new Queue<string>();
            FillWithData(items);
            EmptyAndDisplay(items);
        }


        // private methods

        private void FillWithData(Queue<string> items)
        {
            items.Enqueue("First"); // Use the .Enqueue() method to add to the end
            items.Enqueue("Second");
            items.Enqueue("Third");
            items.Enqueue("Fourth");
        }


        private void EmptyAndDisplay(Queue<string> data)
        {
            Console.WriteLine("There are " + data.Count + " items in the queue:");
            foreach (string text in data)
                Console.Write(text + ",");
            Console.WriteLine();
            Console.WriteLine("... now emptying data...");
            while (data.Count > 0)
                Console.WriteLine(data.Dequeue());
            Console.WriteLine();
        }
    }
}
