using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program myApp = new Program();
                Cylinder first = myApp.PromptForCylinder();
                myApp.Display(first);
                Cylinder second = myApp.PromptForCylinder();
                myApp.Display(second);


                Cylinder combined = first + second;
                Console.WriteLine();
                Console.WriteLine("The combined volume is {0} ({0} = {1}+{2})", combined.Volume, first.Volume, second.Volume);

                // force an exception ....
                int zero = 0, five = 5;
                int impossible = five / zero;
                Console.WriteLine("This should never really appear... the above line is a problem/bug");
                Console.WriteLine(impossible); // is it??
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Bad data...." + ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Uh-oh... I tried adding Cylinders, but all I got was this:");
                Console.WriteLine("\t" + ex.Message);
            }
            catch (Exception ex)
            {
                // The Exception class is the top class in the set of inherited Exception Classes
                Console.WriteLine("that was totally unexpected...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                // A finally block will run whether or not an exception occurs, in otherwords do some cleanup
                Console.WriteLine("Goodbye...");
                Console.Read();

            }
        }

        // Instance (non-static) methods for my Program
        private void Display(Cylinder data)
        {
            Console.WriteLine("The {0}x{1} cylinder has a volume of {2}", data.Radius, data.Height, data.Volume);

        }
        private Cylinder PromptForCylinder()
        {
            Console.WriteLine("Enter Data for a cylinder.");
            Console.Write("\tHeight:");
            double h = double.Parse(Console.ReadLine());
            Console.Write("\tRadius:");
            double r = double.Parse(Console.ReadLine());
            return new Cylinder(r, h);
        }

    }
}
