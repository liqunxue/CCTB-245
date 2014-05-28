// using statements allow me access to the classes in the stated namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.AdHoc_Demo; // To have access to my various collection-class demos

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run some of the demos
            // ArrayDemo demo1 = new ArrayDemo();
            // demo1.Run();

            ListDemo demo2 = new ListDemo();
            demo2.Run();

        }
    }
}
