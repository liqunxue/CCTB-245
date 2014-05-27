using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            // DemoInheritance();
            // DemoPolymorphism(); // This is a "Method Call" - It tells the method to run

            DemoOperatorOverloading();
        }

        static void DemoOperatorOverloading()
        {
            Cylinder barrel = new Cylinder(5, 20);
            Console.WriteLine("The volume is " + barrel.Volume);

            Cylinder doubleBarrel = barrel + barrel;
            Console.WriteLine("The volume is " + doubleBarrel.Volume);
        }


        // This is a "Method Declaration" - It states what the instructions are
        static void DemoPolymorphism()
        {
            Store otherStore = new Store(2, "Future Buy");
            Product myProduct = otherStore.GetProducts(5);
            myProduct.Purchase(); // Call the method

            LaptopComputer myMac = new LaptopComputer();
            myMac.Name = "Macbook Pro";
            myMac.Purchase();

        }

        static void DemoInheritance()
        {
            // Use my store and look up a product
            Store myStore = new Store(1, "Best Store");
            Product myProduct = myStore.GetProducts(5);

            Console.WriteLine("Store is {0}, Product is {1}", myStore.Name, myProduct.Name);

            // Explore the Computer class
            // Instantiate (create) an object of data type Computer
            Computer oldMachine = new Computer();
            oldMachine.CPU = "x86";
            oldMachine.OperatingSystem = "Windows XP";
            oldMachine.Name = "HP 1234-x"; // some brand-name I bought
            oldMachine.Id = 25;

            // Instantiate a LaptopComputer, with an Initializer List
            LaptopComputer newMachine = new LaptopComputer()
            {
                Id = 77,
                Name = "HP 532-Y",
                CPU = "Athalon Tiger",
                OperatingSystem = "Windows 10",
                MonitorSize = 27.5
            };
            // newMachine

        }
          
    }
}
